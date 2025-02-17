# OrderProcessingApp

Feature Branch  - "Feature-OrderProcessingApp"  COde was developed in feature branch and merged into main branch.
Main Branch - Main

Technical Summary - Solution for Order Processing Application structure is as below.  It has UI, Business and Repository project  but  for the given business senarios there is no use of reposity class , hence it is empty.   Please look only into the UI and Business layer of the project.
Also Each project file has sepearte unit test case projects  but considering unit tetsing of only business logic, the unit test case wriiten only for Business layer projects.  Other two unit test projects are empty for now

![image](https://github.com/user-attachments/assets/eff8be1e-07b7-4f14-ab2d-cd3deafb7462)

Screenshot of the Order entry form 

![image](https://github.com/user-attachments/assets/49b2b652-ed43-4a70-8439-250f0e234770)

Screenshot of the order summary page 

![image](https://github.com/user-attachments/assets/b55de0b3-e551-480a-8a9c-3a9b8cef8172)

CICD Pipeline has been intergarted with Main branch. When pull request is merged from feature branch to main branch, CICD is run autometically and creating new build along with unit test case run autometically.
Below are the screenshot of 4 unit test case that integrated and runs autometically when CICD runs 
![image](https://github.com/user-attachments/assets/bcb25db9-592d-48c4-ab60-f2ce8ba94acd)
