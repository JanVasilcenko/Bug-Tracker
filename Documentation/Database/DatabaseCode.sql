CREATE SCHEMA bugtracker;
SET SEARCH_PATH TO bugtracker;

CREATE DOMAIN ids AS INTEGER NOT NULL;
CREATE DOMAIN names AS VARCHAR(100) NOT NULL;
CREATE DOMAIN textblock AS VARCHAR(500);

CREATE TABLE Users(
	userEmail VARCHAR(500)NOT NULL PRIMARY KEY,
	userPassword VARCHAR(500) NOT NULL,
	userName names
);

CREATE TABLE Team(
	teamId ids PRIMARY KEY,
	teamName names
);

CREATE TABLE Project(
	projectId ids PRIMARY KEY,
	projectName names,
	projectDescription textblock,
	projectStatus VARCHAR(9) NOT NULL CHECK(projectStatus IN ('Open', 'Completed')) DEFAULT 'Open',
	teamId ids,
	FOREIGN KEY(teamId) REFERENCES Team(teamId)
);

CREATE TABLE Bug(
	bugId ids PRIMARY KEY,
	bugName names,
	bugDescription textblock,
	bugDetail textblock,
	bugStatus VARCHAR(20) NOT NULL CHECK(bugstatus IN ('Open', 'In Progress', 'Testing', 'Completed')) DEFAULT 'Open',
	projectId ids,
	FOREIGN KEY(projectId) REFERENCES Project(projectId)
);

CREATE TABLE Post(
	postId ids PRIMARY KEY,
	postTitle names,
	postMessage textblock,
	userEmail VARCHAR(500) NOT NULL,
	projectId ids,
	FOREIGN KEY(userEmail) REFERENCES Users(userEmail),
	FOREIGN KEY(projectId) REFERENCES Project(projectId)
);


CREATE TABLE UsersTeam(
	userEmail VARCHAR(500) NOT NULL,
	teamId ids,
	PRIMARY KEY(userEmail, teamId),
	FOREIGN KEY(userEmail) REFERENCES Users(userEmail),
	FOREIGN KEY(teamId) REFERENCES Team(teamId)
);
















