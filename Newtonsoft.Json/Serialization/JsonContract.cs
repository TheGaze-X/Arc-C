using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[Preserve]
	public abstract class JsonContract
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E5")]
		public Type UnderlyingType
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E6")]
		public Type CreatedType
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x4DA6460", Offset = "0x4DA5060", VA = "0x184DA6460")]
			set
			{
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000042C0 File Offset: 0x000024C0
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E7")]
		public bool? IsReference
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x4DA5DD0", Offset = "0x4DA49D0", VA = "0x184DA5DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x4DA64D0", Offset = "0x4DA50D0", VA = "0x184DA64D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E8")]
		public JsonConverter Converter
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E9")]
		internal JsonConverter InternalConverter
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EA")]
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x4DA5DE0", Offset = "0x4DA49E0", VA = "0x184DA5DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x4DA5F10", Offset = "0x4DA4B10", VA = "0x184DA5F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EC")]
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x4DA6200", Offset = "0x4DA4E00", VA = "0x184DA6200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000ED")]
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x4DA6330", Offset = "0x4DA4F30", VA = "0x184DA6330")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EE")]
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x4DA6040", Offset = "0x4DA4C40", VA = "0x184DA6040")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EF")]
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializedCallbacks collection.")]
		public MethodInfo OnDeserialized
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x4DA5E70", Offset = "0x4DA4A70", VA = "0x184DA5E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x4DA64E0", Offset = "0x4DA50E0", VA = "0x184DA64E0")]
			set
			{
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F0")]
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializingCallbacks collection.")]
		public MethodInfo OnDeserializing
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x4DA5FA0", Offset = "0x4DA4BA0", VA = "0x184DA5FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x4DA6580", Offset = "0x4DA5180", VA = "0x184DA6580")]
			set
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F1")]
		[Obsolete("This property is obsolete and has been replaced by the OnSerializedCallbacks collection.")]
		public MethodInfo OnSerialized
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x4DA6290", Offset = "0x4DA4E90", VA = "0x184DA6290")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x4DA6740", Offset = "0x4DA5340", VA = "0x184DA6740")]
			set
			{
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F2")]
		[Obsolete("This property is obsolete and has been replaced by the OnSerializingCallbacks collection.")]
		public MethodInfo OnSerializing
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x4DA63C0", Offset = "0x4DA4FC0", VA = "0x184DA63C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x4DA67E0", Offset = "0x4DA53E0", VA = "0x184DA67E0")]
			set
			{
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F3")]
		[Obsolete("This property is obsolete and has been replaced by the OnErrorCallbacks collection.")]
		public MethodInfo OnError
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x4DA60D0", Offset = "0x4DA4CD0", VA = "0x184DA60D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x4DA6620", Offset = "0x4DA5220", VA = "0x184DA6620")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F4")]
		public Func<object> DefaultCreator
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000042D8 File Offset: 0x000024D8
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F5")]
		public bool DefaultCreatorNonPublic
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x906A30", Offset = "0x905630", VA = "0x180906A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x906A90", Offset = "0x905690", VA = "0x180906A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x4DA5C60", Offset = "0x4DA4860", VA = "0x184DA5C60")]
		internal JsonContract(Type underlyingType)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x4DA5A60", Offset = "0x4DA4660", VA = "0x184DA5A60")]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x4DA5860", Offset = "0x4DA4460", VA = "0x184DA5860")]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x4DA5450", Offset = "0x4DA4050", VA = "0x184DA5450")]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x4DA5320", Offset = "0x4DA3F20", VA = "0x184DA5320")]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x4DA5650", Offset = "0x4DA4250", VA = "0x184DA5650")]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x4DA4FE0", Offset = "0x4DA3BE0", VA = "0x184DA4FE0")]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x4DA5180", Offset = "0x4DA3D80", VA = "0x184DA5180")]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x10")]
		internal bool IsNullable;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x11")]
		internal bool IsConvertable;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x12")]
		internal bool IsEnum;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x18")]
		internal Type NonNullableUnderlyingType;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x20")]
		internal ReadType InternalReadType;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x24")]
		internal JsonContractType ContractType;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x28")]
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x29")]
		internal bool IsSealed;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x2A")]
		internal bool IsInstantiable;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x30")]
		private List<SerializationCallback> _onDeserializedCallbacks;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x38")]
		private IList<SerializationCallback> _onDeserializingCallbacks;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x40")]
		private IList<SerializationCallback> _onSerializedCallbacks;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x48")]
		private IList<SerializationCallback> _onSerializingCallbacks;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x50")]
		private IList<SerializationErrorCallback> _onErrorCallbacks;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x58")]
		private Type _createdType;
	}
}
