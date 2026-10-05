using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x5123450", Offset = "0x5122050", VA = "0x185123450")]
		public EditorBrowsableAttribute()
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x170001AE")]
		public EditorBrowsableState State
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return EditorBrowsableState.Always;
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x51233D0", Offset = "0x5121FD0", VA = "0x1851233D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x10")]
		private EditorBrowsableState browsableState;
	}
}
