using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CBE RID: 31934
	[Token(Token = "0x2007CBE")]
	[Serializable]
	public class tkFoldoutMetadata : IGraphMetadataItemPersistent
	{
		// Token: 0x0602C98C RID: 182668 RVA: 0x000E1090 File Offset: 0x000DF290
		[Token(Token = "0x602C98C")]
		[Address(RVA = "0x160BEE0", Offset = "0x160AAE0", VA = "0x18160BEE0", Slot = "4")]
		private bool ShouldSerialize()
		{
			return default(bool);
		}

		// Token: 0x0602C98D RID: 182669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C98D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public tkFoldoutMetadata()
		{
		}

		// Token: 0x040403E7 RID: 263143
		[Token(Token = "0x40403E7")]
		[FieldOffset(Offset = "0x10")]
		public bool IsExpanded;
	}
}
