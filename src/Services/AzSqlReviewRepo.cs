using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Entities;
using src.Models.Dtos;
using System.Collections;

namespace src.Services
{
    public class AzSqlReviewRepo : IReviewRepository
    {
        public readonly ApplicationDbContext _context;

        private static int maxPageSize = 100;
        public IQueryable<Review> Reviews => throw new NotImplementedException();

        public AzSqlReviewRepo(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

       
        public void AddReview(Review review)
        {            
            if (review.UserId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(review));
            }

            if (review == null)
            {
                throw new ArgumentNullException(nameof(review));
            }
            _context.Reviews.Add(review);
          
        }

       
            public Review GetReviewById(Guid id)
            {
                if (id == Guid.Empty)
                {
                    throw new ArgumentNullException(nameof(id));
                }
                var review = _context.Reviews.Where(c => c.ReviewId == id).SingleOrDefault();
                if (review == null)
                {

                    throw new NullReferenceException("Data not found");
                }
                return review;
            }


        public IEnumerable<Review> GetReviews(int pageNumber, int pageSize)
        {

            int defaultPageSize = 10;
            int defaultPageNumber = 0;

            if (pageSize > maxPageSize || pageSize < 0)
            {
                pageSize = defaultPageSize;
            }
            int availableNumberOfPages = _context.Reviews.Count() / pageSize;
            if (pageNumber > availableNumberOfPages)
            {
                pageNumber = defaultPageNumber;
            }
            var reviews = _context.Reviews.Skip((pageSize * pageNumber)).Take(pageSize);
            return reviews;
        }

        public IEnumerable<ReviewForDisplayDto> GetInconclusiveReviews()
        {
            var reviews = _context.Reviews
                .Where(review => review.Status == StatusType.Inconclusive)
                .Select(r => new ReviewForDisplayDto
                {
                    ReviewId= r.ReviewId,
                    Email= r.Email,
                    ReviewString= r.ReviewString,
                    Status  = r.Status,
                    TimeStamp = r.TimeStamp
                }).ToList();

            if (reviews == null)
            {
                return Enumerable.Empty<ReviewForDisplayDto>();
            }
            return reviews;
        }

        public void DeleteReview(Guid reviewId)
        {
            Review review = GetReviewById(reviewId);
            _context.Reviews.Remove(review);
        }

        /// <summary>
        /// Deletes the reviews associated with a particular user
        /// </summary>
        /// <param name="userId">The particular users Id</param>
        public void DeleteReviews(Guid userId)
        {
            var reviews = _context.Reviews.Where(x => x.UserId == userId).ToList();
            _context.Reviews.RemoveRange(reviews);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public Review UpdateReviewLawyer(ReviewForUpdateDTO review)
        {
            if (review == null)
            {
                throw new NotImplementedException("No review is passed");
            }
            Review reviewToUpdate = _context.Reviews.FirstOrDefault(r => r.ReviewId == review.ReviewId);

            if (reviewToUpdate == null)
            {
                throw new NullReferenceException("Data not found");
            }

            reviewToUpdate.ReviewString = review.ReviewString;
            reviewToUpdate.Status = review.Status;

            _context.SaveChanges();

            return reviewToUpdate;
        }
        
        public async Task<List<SuccessfulReviewsDto>> GetAllSuccessfulReview()
        {
            var resultModel = new List<SuccessfulReviewsDto>();

            var query = await _context.Reviews
                .Where(x => x.Status == StatusType.Successful)
                .Select(x => new SuccessfulReviewsDto()
                {
                    ReviewId = x.ReviewId,
                    Email = x.Email,
                    Status = x.Status,
                    TimeStamp = x.TimeStamp,
                    Message = x.ReviewString,
                }).ToListAsync();

            if (query != null)
            {
                resultModel = query;
            }

            return resultModel;
        }

        public async Task<UserComplains> PostUserComplains(CreateUserComplainsDto complains)
        {
            var data = new UserComplains()
            {
                ComplaintId = Guid.NewGuid(),
                ComplaintMessage = complains.ComplaintMessage,
                TimeStamp = DateTime.Now,
                UserId = complains.UserId
            };

            var saveData = await _context.UserComplaint.AddAsync(data);
            Save();

            return data;
        }
    }
}
















