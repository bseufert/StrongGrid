﻿using StrongGrid.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StrongGrid.Resources
{
	/// <summary>
	/// Allows you to manage email addresses that have been declared invalid.
	/// </summary>
	/// <remarks>
	/// See https://sendgrid.com/docs/API_Reference/Web_API_v3/invalid_emails.html
	/// </remarks>
	public interface IInvalidEmails
	{
		/// <summary>
		/// Retrieve all invalid emails.
		/// </summary>
		/// <param name="startDate">The start date.</param>
		/// <param name="endDate">The end date.</param>
		/// <param name="limit">The limit.</param>
		/// <param name="offset">The offset.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// An array of <see cref="InvalidEmail" />.
		/// </returns>
		Task<InvalidEmail[]> GetAllAsync(DateTime? startDate = null, DateTime? endDate = null, int limit = 25, int offset = 0, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve invalid emails for a given email address.
		/// </summary>
		/// <param name="emailAddress">The email address.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// An array of <see cref="InvalidEmail" />.
		/// </returns>
		Task<InvalidEmail[]> GetAsync(string emailAddress, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete all invalid emails.
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// The async task.
		/// </returns>
		Task DeleteAllAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete multiple invalid emails.
		/// </summary>
		/// <param name="emailAddresses">The email addresses.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// The async task.
		/// </returns>
		Task DeleteMultipleAsync(IEnumerable<string> emailAddresses, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a specific invalid emails.
		/// </summary>
		/// <param name="emailAddress">The email address.</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// The async task.
		/// </returns>
		Task DeleteAsync(string emailAddress, CancellationToken cancellationToken = default(CancellationToken));
	}
}
