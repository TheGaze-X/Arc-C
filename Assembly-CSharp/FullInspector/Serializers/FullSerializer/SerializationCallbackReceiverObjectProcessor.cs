using System;
using FullSerializer;
using Il2CppDummyDll;

namespace FullInspector.Serializers.FullSerializer
{
	// Token: 0x02007C6F RID: 31855
	[Token(Token = "0x2007C6F")]
	public class SerializationCallbackReceiverObjectProcessor : fsObjectProcessor
	{
		// Token: 0x0602C825 RID: 182309 RVA: 0x000E06E8 File Offset: 0x000DE8E8
		[Token(Token = "0x602C825")]
		[Address(RVA = "0x2863A90", Offset = "0x2862690", VA = "0x182863A90", Slot = "4")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C826 RID: 182310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C826")]
		[Address(RVA = "0x2863D40", Offset = "0x2862940", VA = "0x182863D40", Slot = "5")]
		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C827 RID: 182311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C827")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void OnAfterSerialize(Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C828 RID: 182312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C828")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void OnBeforeDeserialize(Type storageType, ref fsData data)
		{
		}

		// Token: 0x0602C829 RID: 182313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C829")]
		[Address(RVA = "0x2863CD0", Offset = "0x28628D0", VA = "0x182863CD0", Slot = "9")]
		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C82A RID: 182314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C82A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SerializationCallbackReceiverObjectProcessor()
		{
		}
	}
}
