Dapplo.PowerShell.Jira
=====================

This project gives PowerShell CmdLets for accessing Atlassian JIRA servers.
After importing the DLL, you can:
# Get-JiraIssue
# Get-JiraProjects
# Add-JiraAttachment

Example for adding an attachment:
Add-JiraAttachment -JiraUri <jira-uri> -Username <username> -Password <password> -IssueKey <issue-key> -Filename <filename in jira> -Filepath <filepath> -ContentType "application/xml"
