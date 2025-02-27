// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Reservations.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A Class representing a ReservationOrder along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ReservationOrderResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetReservationOrderResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetReservationOrder method.
    /// </summary>
    public partial class ReservationOrderResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReservationOrderResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(Guid reservationOrderId)
        {
            var resourceId = $"/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _reservationOrderClientDiagnostics;
        private readonly ReservationOrderRestOperations _reservationOrderRestClient;
        private readonly ClientDiagnostics _reservationDetailReservationClientDiagnostics;
        private readonly ReservationRestOperations _reservationDetailReservationRestClient;
        private readonly ClientDiagnostics _calculateRefundClientDiagnostics;
        private readonly CalculateRefundRestOperations _calculateRefundRestClient;
        private readonly ClientDiagnostics _returnClientDiagnostics;
        private readonly ReturnRestOperations _returnRestClient;
        private readonly ReservationOrderData _data;

        /// <summary> Initializes a new instance of the <see cref="ReservationOrderResource"/> class for mocking. </summary>
        protected ReservationOrderResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ReservationOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ReservationOrderResource(ArmClient client, ReservationOrderData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReservationOrderResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string reservationOrderApiVersion);
            _reservationOrderRestClient = new ReservationOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationOrderApiVersion);
            _reservationDetailReservationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReservationDetailResource.ResourceType, out string reservationDetailReservationApiVersion);
            _reservationDetailReservationRestClient = new ReservationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationDetailReservationApiVersion);
            _calculateRefundClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _calculateRefundRestClient = new CalculateRefundRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _returnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _returnRestClient = new ReturnRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Capacity/reservationOrders";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ReservationOrderData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ReservationDetailResources in the ReservationOrder. </summary>
        /// <returns> An object representing collection of ReservationDetailResources and their operations over a ReservationDetailResource. </returns>
        public virtual ReservationDetailCollection GetReservationDetails()
        {
            return GetCachedClient(Client => new ReservationDetailCollection(Client, Id));
        }

        /// <summary>
        /// Get specific `Reservation` details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ReservationDetailResource>> GetReservationDetailAsync(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetReservationDetails().GetAsync(reservationId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get specific `Reservation` details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ReservationDetailResource> GetReservationDetail(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetReservationDetails().Get(reservationId, expand, cancellationToken);
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReservationOrderResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderResource.Get");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.GetAsync(Guid.Parse(Id.Name), expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReservationOrderResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderResource.Get");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.Get(Guid.Parse(Id.Name), expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Purchase `ReservationOrder` and create resource under the specified URI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Purchase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationOrderResource>> UpdateAsync(WaitUntil waitUntil, ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderResource.Update");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.PurchaseAsync(Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationOrderResource>(new ReservationOrderOperationSource(Client), _reservationOrderClientDiagnostics, Pipeline, _reservationOrderRestClient.CreatePurchaseRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Purchase `ReservationOrder` and create resource under the specified URI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Purchase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ReservationOrderResource> Update(WaitUntil waitUntil, ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderResource.Update");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.Purchase(Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationOrderResource>(new ReservationOrderOperationSource(Client), _reservationOrderClientDiagnostics, Pipeline, _reservationOrderRestClient.CreatePurchaseRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Split a `Reservation` into two `Reservation`s with specified quantity distribution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/split</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Split</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed to Split a reservation item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<IList<ReservationDetailData>>> SplitReservationAsync(WaitUntil waitUntil, SplitContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationOrderResource.SplitReservation");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.SplitAsync(Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<IList<ReservationDetailData>>(new IListOperationSource(), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateSplitRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Split a `Reservation` into two `Reservation`s with specified quantity distribution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/split</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Split</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed to Split a reservation item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<IList<ReservationDetailData>> SplitReservation(WaitUntil waitUntil, SplitContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationOrderResource.SplitReservation");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Split(Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new ReservationsArmOperation<IList<ReservationDetailData>>(new IListOperationSource(), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateSplitRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Merge the specified `Reservation`s into a new `Reservation`. The two `Reservation`s being merged must have same properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/merge</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Merge</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed for commercial request for a reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<IList<ReservationDetailData>>> MergeReservationAsync(WaitUntil waitUntil, MergeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationOrderResource.MergeReservation");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.MergeAsync(Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<IList<ReservationDetailData>>(new IListOperationSource(), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateMergeRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Merge the specified `Reservation`s into a new `Reservation`. The two `Reservation`s being merged must have same properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/merge</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Merge</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed for commercial request for a reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<IList<ReservationDetailData>> MergeReservation(WaitUntil waitUntil, MergeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationOrderResource.MergeReservation");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Merge(Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new ReservationsArmOperation<IList<ReservationDetailData>>(new IListOperationSource(), _reservationDetailReservationClientDiagnostics, Pipeline, _reservationDetailReservationRestClient.CreateMergeRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Change directory (tenant) of `ReservationOrder` and all `Reservation` under it to specified tenant id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/changeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_ChangeDirectory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information needed to change directory of reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ChangeDirectoryDetail>> ChangeDirectoryAsync(ChangeDirectoryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderResource.ChangeDirectory");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.ChangeDirectoryAsync(Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Change directory (tenant) of `ReservationOrder` and all `Reservation` under it to specified tenant id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/changeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_ChangeDirectory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information needed to change directory of reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ChangeDirectoryDetail> ChangeDirectory(ChangeDirectoryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderResource.ChangeDirectory");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.ChangeDirectory(Guid.Parse(Id.Name), content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate price for returning `Reservations` if there are no policy errors.
        /// 
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/calculateRefund</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CalculateRefund_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information needed for calculating refund of a reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ReservationCalculateRefundResult>> CalculateRefundAsync(ReservationCalculateRefundContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _calculateRefundClientDiagnostics.CreateScope("ReservationOrderResource.CalculateRefund");
            scope.Start();
            try
            {
                var response = await _calculateRefundRestClient.PostAsync(Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate price for returning `Reservations` if there are no policy errors.
        /// 
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/calculateRefund</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CalculateRefund_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information needed for calculating refund of a reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ReservationCalculateRefundResult> CalculateRefund(ReservationCalculateRefundContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _calculateRefundClientDiagnostics.CreateScope("ReservationOrderResource.CalculateRefund");
            scope.Start();
            try
            {
                var response = _calculateRefundRestClient.Post(Guid.Parse(Id.Name), content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return a reservation and get refund information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/return</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Return_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed for returning reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationOrderResource>> ReturnAsync(WaitUntil waitUntil, ReservationRefundContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _returnClientDiagnostics.CreateScope("ReservationOrderResource.Return");
            scope.Start();
            try
            {
                var response = await _returnRestClient.PostAsync(Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationOrderResource>(new ReservationOrderOperationSource(Client), _returnClientDiagnostics, Pipeline, _returnRestClient.CreatePostRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return a reservation and get refund information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/return</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Return_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Information needed for returning reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ReservationOrderResource> Return(WaitUntil waitUntil, ReservationRefundContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _returnClientDiagnostics.CreateScope("ReservationOrderResource.Return");
            scope.Start();
            try
            {
                var response = _returnRestClient.Post(Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationOrderResource>(new ReservationOrderOperationSource(Client), _returnClientDiagnostics, Pipeline, _returnRestClient.CreatePostRequest(Guid.Parse(Id.Name), content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
