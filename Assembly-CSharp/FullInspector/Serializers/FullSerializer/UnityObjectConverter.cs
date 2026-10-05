using System;
using FullSerializer;
using Il2CppDummyDll;

namespace FullInspector.Serializers.FullSerializer
{
	// Token: 0x02007C70 RID: 31856
	[Token(Token = "0x2007C70")]
	public class UnityObjectConverter : fsConverter
	{
		// Token: 0x0602C82B RID: 182315 RVA: 0x000E0700 File Offset: 0x000DE900
		[Token(Token = "0x602C82B")]
		[Address(RVA = "0x2865280", Offset = "0x2863E80", VA = "0x182865280", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C82C RID: 182316 RVA: 0x000E0718 File Offset: 0x000DE918
		[Token(Token = "0x602C82C")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C82D RID: 182317 RVA: 0x000E0730 File Offset: 0x000DE930
		[Token(Token = "0x602C82D")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C82E RID: 182318 RVA: 0x000E0748 File Offset: 0x000DE948
		[Token(Token = "0x602C82E")]
		[Address(RVA = "0x28654D0", Offset = "0x28640D0", VA = "0x1828654D0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C82F RID: 182319 RVA: 0x000E0760 File Offset: 0x000DE960
		[Token(Token = "0x602C82F")]
		[Address(RVA = "0x2865360", Offset = "0x2863F60", VA = "0x182865360", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C830 RID: 182320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C830")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C831 RID: 182321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C831")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UnityObjectConverter()
		{
		}
	}
}
