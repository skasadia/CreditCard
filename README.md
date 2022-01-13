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
5. AP alllows user to capture applicant details and provide appropriate response as requested in brief 
6. at the time of when applicant details is captured and marketplace search is peformed , search entry is in logged in database 
7. Api allows you to see who is used tool 

================================================ To D0=================
1. Add API Versioning Support 
2. improve security on HTTPS security 
3. Move Data access to service 
4. Map models automaticlly with automapper nuget
5. Create a link class 
6. rewrite links with filter 
7. Rewrite resource with HREFS
8. Sorting collection 
9. Serialize the add applicant form meta data 
10. Discovarable queies using forms 
11. compress responses 
12. HTTP caching 
13. ETAG header 
14. Add authentication and Authorization


