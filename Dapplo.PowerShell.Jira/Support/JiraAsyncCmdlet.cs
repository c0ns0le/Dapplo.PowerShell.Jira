//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2015-2016 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.PowerShell.Jira
// 
//  Dapplo.PowerShell.Jira is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.PowerShell.Jira is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.PowerShell.Jira. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#region using

using System;
using System.Management.Automation;
using Dapplo.Jira;

#endregion

namespace Dapplo.PowerShell.Jira.Support
{
	public class JiraAsyncCmdlet : AsyncCmdlet
	{
		protected JiraApi JiraApi;

		[Parameter(Mandatory = true, Position = 0, ValueFromPipelineByPropertyName = true)]
		public Uri JiraUri { get; set; }

		[Parameter(ValueFromPipelineByPropertyName = true)]
		public string Password { get; set; }

		[Parameter(ValueFromPipelineByPropertyName = true)]
		public string Username { get; set; }

		protected override void BeginProcessing()
		{
			JiraApi = new JiraApi(JiraUri);
			if (Username != null)
			{
				JiraApi.SetBasicAuthentication(Username, Password);
			}
		}
	}
}