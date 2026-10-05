using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[Preserve]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x4DD86D0", Offset = "0x4DD72D0", VA = "0x184DD86D0")]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x4DD6D30", Offset = "0x4DD5930", VA = "0x184DD6D30")]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x4DD2D20", Offset = "0x4DD1920", VA = "0x184DD2D20")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x4DD2CA0", Offset = "0x4DD18A0", VA = "0x184DD2CA0")]
		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x4DD6300", Offset = "0x4DD4F00", VA = "0x184DD6300")]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x4DD6660", Offset = "0x4DD5260", VA = "0x184DD6660")]
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4DD3910", Offset = "0x4DD2510", VA = "0x184DD3910")]
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x4DD7380", Offset = "0x4DD5F80", VA = "0x184DD7380")]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x4DD7280", Offset = "0x4DD5E80", VA = "0x184DD7280")]
		private bool ShouldWriteProperty(object memberValue, JsonProperty property)
		{
			return default(bool);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x4DD28A0", Offset = "0x4DD14A0", VA = "0x184DD28A0")]
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4DD7E90", Offset = "0x4DD6A90", VA = "0x184DD7E90")]
		private void WriteReference(JsonWriter writer, object value)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x4DD31D0", Offset = "0x4DD1DD0", VA = "0x184DD31D0")]
		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x4DD7700", Offset = "0x4DD6300", VA = "0x184DD7700")]
		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			return default(bool);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x4DD65A0", Offset = "0x4DD51A0", VA = "0x184DD65A0")]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x4DD3790", Offset = "0x4DD2390", VA = "0x184DD3790")]
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x4DD3610", Offset = "0x4DD2210", VA = "0x184DD3610")]
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x4DD5940", Offset = "0x4DD4540", VA = "0x184DD5940")]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x4DD2070", Offset = "0x4DD0C70", VA = "0x184DD2070")]
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue)
		{
			return default(bool);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x4DD79F0", Offset = "0x4DD65F0", VA = "0x184DD79F0")]
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4DD7CB0", Offset = "0x4DD68B0", VA = "0x184DD7CB0")]
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x4DD84C0", Offset = "0x4DD70C0", VA = "0x184DD84C0")]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4BBDDE0", Offset = "0x4BBC9E0", VA = "0x184BBDDE0")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4BBDDE0", Offset = "0x4BBC9E0", VA = "0x184BBDDE0")]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4BBDDE0", Offset = "0x4BBC9E0", VA = "0x184BBDDE0")]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x4DD39A0", Offset = "0x4DD25A0", VA = "0x184DD39A0")]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x4DD4EB0", Offset = "0x4DD3AB0", VA = "0x184DD4EB0")]
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x4DD5790", Offset = "0x4DD4390", VA = "0x184DD5790")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x4DD53D0", Offset = "0x4DD3FD0", VA = "0x184DD53D0")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x4DD80C0", Offset = "0x4DD6CC0", VA = "0x184DD80C0")]
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x4DD4740", Offset = "0x4DD3340", VA = "0x184DD4740")]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x4DD71D0", Offset = "0x4DD5DD0", VA = "0x184DD71D0")]
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			return default(bool);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x4DD7580", Offset = "0x4DD6180", VA = "0x184DD7580")]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x4DD3DE0", Offset = "0x4DD29E0", VA = "0x184DD3DE0")]
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x4DD2E00", Offset = "0x4DD1A00", VA = "0x184DD2E00")]
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			return null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x4DD33A0", Offset = "0x4DD1FA0", VA = "0x184DD33A0")]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x4DD7000", Offset = "0x4DD5C00", VA = "0x184DD7000")]
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x4DD3440", Offset = "0x4DD2040", VA = "0x184DD3440")]
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x38")]
		private Type _rootType;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x40")]
		private int _rootLevel;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<object> _serializeStack;
	}
}
