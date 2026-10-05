using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B79 RID: 31609
	[Token(Token = "0x2007B79")]
	public abstract class fsObjectProcessor
	{
		// Token: 0x0602C3D4 RID: 181204 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
		[Token(Token = "0x602C3D4")]
		[Address(RVA = "0x2832410", Offset = "0x2831010", VA = "0x182832410", Slot = "4")]
		public virtual bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C3D5 RID: 181205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C3D6 RID: 181206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C3D7 RID: 181207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
		{
		}

		// Token: 0x0602C3D8 RID: 181208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
		{
		}

		// Token: 0x0602C3D9 RID: 181209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public virtual void OnAfterDeserialize(Type storageType, object instance)
		{
		}

		// Token: 0x0602C3DA RID: 181210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3DA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected fsObjectProcessor()
		{
		}
	}
}
