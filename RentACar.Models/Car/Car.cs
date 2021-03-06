﻿using RentACar.Models.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models.Car
{
	public class Car
    {
        public Car()
        {

        }
        public Car(string brand, string model, DateTime rentFrom, DateTime rentoTo, string imageUrl, IsCarAvailable isItavaliable)
        {
            this.Brand = brand;
            this.Model = model;
            this.RentFrom = rentFrom;
            this.RentTo = rentoTo;
            this.ImageUrl = imageUrl;
            this.IsTheCarAvailable = isItavaliable;
        }

        [Key]
        public int CarId { get; set; }

        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime RentFrom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime RentTo { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Availablity")]
        public IsCarAvailable IsTheCarAvailable { get; set; }

        public int? PlaceId { get; set; }

    }
}
