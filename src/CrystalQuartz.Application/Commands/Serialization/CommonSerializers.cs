﻿namespace CrystalQuartz.Application.Commands.Serialization
{
    using System;
    using CrystalQuartz.Core.Domain.Activities;
    using CrystalQuartz.Core.Domain.Base;
    using CrystalQuartz.Core.Domain.ObjectTraversing;
    using CrystalQuartz.WebFramework.Serialization;

    public static class CommonSerializers
    {
        public static readonly ISerializer<Type> TypeSerializer = new TypeSerializer();

        public static readonly ISerializer<PropertyValue> PropertySerializer = new PropertyValueSerializer();

        public static readonly ISerializer<ErrorMessage> ErrorMessageSerializer = new ErrorMessageSerializer();

        public static readonly ISerializer<TriggerData> TriggerDataSerializer = new TriggerSerializer();
    }
}