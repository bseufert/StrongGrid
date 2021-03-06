﻿using StrongGrid.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StrongGrid.Resources
{
	/// <summary>
	/// Allows you to create and manage segments.
	/// </summary>
	/// <remarks>
	/// See https://sendgrid.com/docs/API_Reference/Web_API_v3/Marketing_Campaigns/campaigns.html
	/// </remarks>
	public interface ISegments
	{
		/// <summary>
		/// Create a segment.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="listId">The list identifier.</param>
		/// <param name="conditions">The conditions.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// The <see cref="Segment" />.
		/// </returns>
		Task<Segment> CreateAsync(string name, long listId, IEnumerable<SearchCondition> conditions, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve all segments.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// An array of <see cref="Segment" />.
		/// </returns>
		Task<Segment[]> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a segment.
		/// </summary>
		/// <param name="segmentId">The segment identifier.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// The <see cref="Segment" />.
		/// </returns>
		Task<Segment> GetAsync(long segmentId, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update a segment.
		/// </summary>
		/// <param name="segmentId">The segment identifier.</param>
		/// <param name="name">The name.</param>
		/// <param name="listId">The list identifier.</param>
		/// <param name="conditions">The conditions.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// The <see cref="Segment" />.
		/// </returns>
		Task<Segment> UpdateAsync(long segmentId, string name = null, long? listId = null, IEnumerable<SearchCondition> conditions = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a segment.
		/// </summary>
		/// <param name="segmentId">The segment identifier.</param>
		/// <param name="deleteMatchingContacts">if set to <c>true</c> [delete matching contacts].</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// The async task.
		/// </returns>
		Task DeleteAsync(long segmentId, bool deleteMatchingContacts = false, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the recipients on a segment.
		/// </summary>
		/// <param name="segmentId">The segment identifier.</param>
		/// <param name="recordsPerPage">The records per page.</param>
		/// <param name="page">The page.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>
		/// An array of <see cref="Contact" />.
		/// </returns>
		Task<Contact[]> GetRecipientsAsync(long segmentId, int recordsPerPage = 100, int page = 1, CancellationToken cancellationToken = default(CancellationToken));
	}
}
