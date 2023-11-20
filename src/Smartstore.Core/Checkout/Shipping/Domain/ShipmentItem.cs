﻿using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Smartstore.Core.Checkout.Shipping
{
    /// <summary>
    /// Represents a shipment order product variant
    /// </summary>
    public partial class ShipmentItem : BaseEntity
    {
        /// <summary>
        /// Gets or sets the shipment identifier
        /// </summary>
        public int ShipmentId { get; set; }

        /// <summary>
        /// Gets or sets the order item identifier
        /// </summary>
        public int OrderItemId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        private Shipment _shipment;
        /// <summary>
        /// Gets the shipment
        /// </summary>
        public Shipment Shipment
        {
            get => _shipment ?? LazyLoader.Load(this, ref _shipment);
            set => _shipment = value;
        }
    }
}