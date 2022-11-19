import {
	StyledHero,
	StyledHeroMsg,
	StyledHerotxt,
	StyledHerotxtSpan,
	StyledOrange,
	StyledBlue,
} from '../styled/Hero.styled';

export default function Hero() {
	return (
		<>
			<StyledHero>
				<img src="assets/img/Hero-image-Desktop.png" alt="hero" width="540px" />
				<StyledHeroMsg>
					<StyledBlue>
						Who Are <StyledOrange>We</StyledOrange>?
					</StyledBlue>
					<StyledHerotxt>
						We are the team offering you a trusted, convenient, and professional
						service.{' '}
						<StyledHerotxtSpan>
							We boast of a team of{' '}
							<StyledOrange>legal professionals</StyledOrange> and{' '}
							<StyledOrange>reputation management consultants</StyledOrange>,
							well equipped with in-depth knowledge in people and brand
							management.
						</StyledHerotxtSpan>{' '}
						We cater to businesses and public figures that have a lot riding on
						their reputation.
					</StyledHerotxt>
				</StyledHeroMsg>
			</StyledHero>
		</>
	);
}
