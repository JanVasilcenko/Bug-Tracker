Users(userEmail, userPassword, userName)
PRIMARY KEY(userEmail)

Team(teamId, teamName)
PRIMARY KEY(teamId)

Project(projectId, projectName, porjectDescription, projectStatus, teamId)
PRIMARY KEY(projectId)
FOREIGN KEY(teamId) REFERENCES Team(teamId)

Bug(bugId, bugName, bugDescription, bugDetail, bugStatus, projectId)
PRIMARY KEY(bugId)
FOREIGN KEY(projectId) REFERENCES Project(projectId)

Post(postId, postTitle, postMessage, userEmail, projectId)
PRIMARY KEY(postId)
FOREIGN KEY(userEmail) REFERENCES Users(userEmail)
FOREIGN KEY(projectId) REFERENCES Project(projectId)

UsersTeam(userEmail, teamId)
PRIMARY KEY(userEmail, teamId)
FOREIGN KEY(userEmail) REFERENCES Users(userEmail)
FOREIGN KEY(teamId) REFERENCES Team(teamId)