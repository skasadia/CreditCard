# CreditCard
pre-qualification 

1. Run project and Use Swagger to see API 

https://localhost:44313/swagger/index.html

2. use can also use postman: https://localhost:44313

Root controller request will show you below response 

//=============================================
{
    "href": "https://localhost:44313/",
    "applicantChecks": {
        "href": "https://localhost:44313/applicantchecks"
    },
    "addApplicantChecks": {
        "href": "https://localhost:44313/applicantchecks/addapplicant"     //From body Jason parm
    },
    "search": {
        "href": "https://localhost:44313/searches"
    }
}
/==================================================Current Version of API

3. Project Uses In memory database 
4. Data has been seeded for intial testing 
5. API alllows user to capture applicant details and provide response with appropriate with suitability
6. at the time of when applicant details is captured and marketplace search is peformed , search entry is in logged in database 
7. Api allows you to see who is used tool 

==To D0=
1. improve code implementation with try and catch , badrequest message 
2. imorove ERD desisgn of database 
3. use Fluent api or lazy loading techs
4. Add API Versioning Support 
5. improve security on HTTPS security 
6. Move Data access to service 
7. Map models automaticlly with automapper nuget
8. Create a link class 
9. rewrite links with filter 
10. Rewrite resource with HREFS
11. Sorting collection 
12. Serialize the add applicant form meta data 
13. Discovarable queies using forms 
14. compress responses 
15. HTTP caching 
16. ETAG header 
17. Add authentication and Authorization


