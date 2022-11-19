import React from 'react'
import styled from "styled-components";
import Footer from '../../components/Reusables/FooterComponents/ReUsableFooter.jsx'
import Header from '../../components/Layout/Header.jsx';

const Headtext  = styled.h2`
  color: #01B0D8;
font-size:1.8em;
`

const Termsofuse = () => {
   const Heading =({text})=>(
<Headtext>{text} </Headtext>
   )
  return (

<>
 <Header/>
    <div className='w-4/5 m-auto'>     

    <div> 
     <Heading text='Effective March 2022' />
    <article>
      <p>
      FixIt  operates FixIt.com and associated sites and mobile applications.
      </p>
      <p>Please read these Terms of Use carefully, They govern your access to and use of FixIt.com, Its content, and the services offered on or through it.These Terms of Use constitute a binding legal agreement between you and us.
</p>
      <p>YOUR ACCESS OR USE OF OUR WEBSITE MEANS THAT YOU HAVE READ AND YOU UNDERSTAND AND AGREE TO BE BOUND BY THESE TERMS OF USE. IF YOU ACCESS OR USE OUR WEBSITE ON BEHALF OF AN ENTITY, YOU REPRESENT THAT YOU HAVE THE AUTHORITY TO BIND THAT ENTITY, AND THESE TERMS OF USE ARE THE AGREEMENT OF SUCH ENTITY. IN THAT EVENT, “YOU,” “YOUR,” “VISITOR,” AND “USER” REFER TO THAT ENTITY. IF YOU DO NOT AGREE TO THESE TERMS, THEN YOU HAVE NO RIGHT TO ACCESS OR USE OUR WEBSITE AND ITS CONTENT AND SERVICES.
</p>
    </article>

    </div>
    
    <div>
    <Heading text='Eligibility' />
    <p> We invite users and visitors to FixIt.com.</p>
    </div>

    <div>
    <Heading text='Services' />
<p> The company provides services such as content removals, content creation, search engine
optimization. Customers are allowed to hire the company to attempt to remove negative
content which the company may or may not accomplish and if not accomplished, the
company may offer suppression services in which the company creates or post positive
content about a customer in order to mitigate the reputational harm done by the existing
negative comments. There will be written agreement setting forth the specific services,
charges, and additional terms specific to the services
</p>
    </div>

    <div>
    <Heading text='License and Ownership' />
    <p> The company may ask to provide information that is considered useful to provide services.
 </p>
    <p> By ordering the service of the company, you grant the company fully-paid, non-exclusive,
transferable, license to use, reproduce, publicly perform, display, publish, create derivatives
works of, exploit any such materials, information including trademarks, logo, photos, videos
that you provide or identify to the company (company materials). </p>

    </div>

    <div>
    <Heading text='Account Creation' />
    <p> The company may offer you the option to create an account which will require you to
provide information needed for the company. This information may include, but not
necessarily limited to; your full name, address, email address, telephone number, date of birth or payment information.</p>

    </div>

    <div>
    <Heading text='Users' />
    <p>Visitors may, subject to these Terms of Use, access and browse FixIt.com and use the other FixIt.com services provided to visitors.
 </p>
<p>  You must be at least 13 years old to post comments on FixIt.com and to give us your email address or any other personally identifiable information about you. If you are under 13, please do not give us any information about yourself, including your name, address, or email address. If we discover that a child under 13 has provided us with personally identifiable information, we will delete such information from our files.
</p>

    </div>

    <div>
    <Heading text='Privacy' />
    <p>Our privacy policy describes how we collect, use and disclose information we receive from
users and visitors. By using Fixit.com, you agree to the terms described in them. If you have
provided the company with your contact information, we can use it to communicate with
you. You may unsubscribe from marketing and research communications by following the
descriptions in them.  </p>

    </div>

    <div>
    <Heading text='Your Obligations' />
    <p>  You must provide accurate and current information reasonably required by us and respond
promptly to our communications in relation to the services.

You release us from any liability incurred by us in connection with
</p>
    <ul> 
    <li>- You must provide the company access to relevant personnel of the client and all
information, documentation and online account as        requested by the company for
the purpose of company’s performance of its obligations under this agreement.
</li>
    <li>- Our reliance upon any image or data or documentation provided by you.
</li>
    <li>- Our compliance with any instructions by you in relation to provision of services.
</li>
    <li>- Any damage to the reputation of the company suffered as a consequence of a
breach of agreement, except that the company has contributed to the loss.</li>

    </ul>

    </div>

    <div>
    <Heading text='Client Acknowledgement' />
    <p> The Client acknowledges that if the completion of services is delayed as a result of
. </p>
    <ul> 
    <li>-  If the company is required to provide services in circumstances order than those
anticipated in this agreement.
</li>
    <li>- If there is any change in the timing of the services.
The date for the provision of services will be delayed.
</li>
    <li>- The company may need to increase the fees relating to the provision of any
amended services which occurs as a result of any event provided that the clients
consent to the increase in fees</li>
    </ul>

    </div>

    <div>
    <Heading text='Fees and Payments' />
    <p> - You agree to pay the fees set out in the proposal as regards the services to be
rendered.
 </p>
    <ul> 
    <p>- Fees will be incurred as planned in the proposal.
 </p>
    <li>- Unless there is an agreement in writing, payment or fees must be made by credit
card or direct debit from your bank account. No services will be rendered until first
payment is made.
</li>

    <li>
- Unless otherwise stated by you in writing, the company will secure your payment
details from the first payment and use this to charge subsequent payment.</li>
    <li></li>
    </ul>

    </div>

    <div>
    <Heading text='Termination' />
    <p> Termination of an agreement can be done by either party on terms specified in the
proposal.
    <p>- The company is allowed to terminate this agreement immediately if the client
refuses to pay the fees by the due date.
  </p>
    <p> - If termination occurs, the client must pay the company all outstanding fees within
seven (7) days. And any invoice provided for work completed before termination. </p>
 </p>

    </div>

    <div>
    <Heading text='Warranties' />
    <p> There will be an acknowledgment that our services may require the use of inputs
information into Third Party systems such as Google and Facebook.
 </p>
    <p> - We will not be accountable for technical fault of the Third Party system or any
changes in their algorithms or, their inability to provide services to you.
 </p>
    <p> - The company do not warrant that services wil be uninterrupted, errors free, hackers
free, virus free or unauthorized access to our services. </p>

    </div>

    <div>
    <Heading text='Refund Policy' />
    <p>  - The company is under no obligation to issue refund for change of mind decisions.
</p>
    <p>- The client acknowledges that the company is under no obligation to provide a refund
for any minor technical issues, for periods of delay caused by the client, for removal
of contents, if contents is removed within the terms of agreement, and if the clientchanges their mind about service engagement.
  </p>
    <p> - The company does not offer refunds unless required by the acts.
 </p>
    <p> - Refund may be granted at the company’s discretion if the services are not fit for its
common purpose and cannot be fixed within a good time, if the services create an
unsafe situation as determined by the company </p>

    </div>


<div>
   <Heading text='Content'/>
   <p>FixIt.com contains both WhoKnows content and user content. The content on WhoKnows.com and any authorized clients are licensed, not sold. Such content is protected by copyright laws and, if applicable, by international treaties.
</p>
</div>

<div>
   <Heading text='Software'/>
   <p> We may provide you with software to interact with our services, such as a browser plug-in like the WhoKnows Discovery Engine to help users discover skills based on their professional web activity. When you register with our services, you will have the opportunity to download our software. You may use our software solely in connection with your authorized use of our services and in compliance with all applicable laws and regulations. By installing our software, except as expressly authorized by these terms, you agree not to: (i) copy or modify the software; (ii) transfer, sublicense, or otherwise redistribute the software to any third party; (iii) transfer or make the software available to multiple users through any means, (iv) disassemble, decompile, or reverse engineer the software, in whole or in part, or permit or authorize a third party to do so; or (v) otherwise exploit the software.
</p>
</div>


<div>
   <Heading text='User Content'/>
   <p>
   User content includes text, graphics, and other material and information (such as your profile attributes, profile image, and expertise) that you upload or post to our services. All listed profile pictures and contact details are managed by the user. Users have the ability to edit and modify all of their listed skills before they are published to the network. Users cannot edit or modify the details listed on each other’s profiles. The complete list of searchable terms to be used by the FixIt Discovery Engine are chosen by the enterprise client’s administrator. All of the content stored within each user’s profile is not publicly available, nor is it searchable by third-party search engines such as Google. If a private network is created for an enterprise client, only employees of that customer on that network with a verified corporate email address can see other users’ content. By uploading or posting any user content, you give us the right and license to store, reproduce, modify, create derivative works of, publish, distribute, transfer, transmit, publicly display, publicly perform, and use your user content in connection with providing our services.

   </p>
   <p>We expect our users and visitors to act responsibly, respectfully, and lawfully on WhoKnows.com. You agree not to post content on your FixIt.com profile that, or the act of posting of which: (1) is unlawful, obscene, pornographic, violent, defamatory, fraudulent, harassing, or harmful to others; (2) violates the rights, including intellectual property rights, or the privacy of any other person; (3) incites or furthers criminal or unlawful acts; (4) constitutes hate speech or a personal attack; (5) contains viruses or other features that can harm WhoKnows.com or other property; (6) impersonates or defames another person; or (7) which may otherwise expose us or our users or visitors to liability. We reserve the right to review any user content and determine, in our discretion, whether it violates these Terms of Use. However, we assume no obligation to do so and have no responsibility for user content on FixIt.com. To report user content, you may contact us through https://FixIt.zendesk.com/hc/en-us.
</p>
   <p>We reserve the right to refuse to post or to remove or delete any user content on WhoKnows.com, at our discretion and with or without notice. When you delete your skills from your WhoKnows Full Profile, we will remove them from your account view and other public areas on FixIt.com as soon as possible, and in any event within 48 hours unless there are unforeseen circumstances. Residual data may remain on our servers for up to 90 days. After such period, we may retain copies only if there is a pending legal issue with such content or if we are otherwise required by law, regulation, or legal process.
</p>
   <p>You represent and warrant that: (1) you own the content that you post on FixIt.com or otherwise have the right to post it on FixIt.com and grant the above licenses with respect to such content; (2) your posting of any content on FixIt.com does not violate any law, regulation, court or administrative order, or the rights of any third party; and (3) your posting of any content on FixIt.com does not breach any contract between you and a third party.
</p>

</div>



<div>
   <Heading text='General'/>
   <p>Our failure to enforce any right will not constitute a waiver of future enforcement of that right. The waiver of any such right will be effective only if in writing and signed by our duly authorized representative. Except as expressly stated in these Terms of Use, the exercise by either party of any of its remedies under these Terms of Use will be without prejudice to its other remedies under these Terms of Use or otherwise. If a court of competent jurisdiction finds any provision of these Terms of Use invalid or unenforceable, that provision will be enforced to the maximum extent permissible and the other provisions of these Terms of Use will remain in full force and effect. The parties have agreed that these Terms of Use and all documents relating thereto will be drawn up in English.
</p>
</div>


<div>
   <Heading text='Company Information'/>
   <p>FixIt, Inc. is a corporation organized under the laws of the State of California, USA.
Our headquarters are at:
FixIt, Inc.425 Liverpool StRedwood City, 
CA 940631-800-348-5031

</p>
</div>


<div>
   <Heading text=''/>
   <p></p>
   <p></p>
   <p></p>
   <p></p>

</div>

    </div>
    <Footer/>

    </>
  )
}

export default Termsofuse