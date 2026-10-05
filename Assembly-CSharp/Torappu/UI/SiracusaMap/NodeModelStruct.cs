using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F8C RID: 16268
	[Token(Token = "0x2003F8C")]
	public struct NodeModelStruct
	{
		// Token: 0x0401F513 RID: 128275
		[Token(Token = "0x401F513")]
		[FieldOffset(Offset = "0x0")]
		public static NodeModelStruct EMPTY;

		// Token: 0x0401F514 RID: 128276
		[Token(Token = "0x401F514")]
		[FieldOffset(Offset = "0x0")]
		public string pointId;

		// Token: 0x0401F515 RID: 128277
		[Token(Token = "0x401F515")]
		[FieldOffset(Offset = "0x8")]
		public SiracusaMapMapNodeViewModel.NodeType nodeType;

		// Token: 0x0401F516 RID: 128278
		[Token(Token = "0x401F516")]
		[FieldOffset(Offset = "0x10")]
		public SiracusaMapMapNodeViewModel.CharCardPatch charCardPatch;

		// Token: 0x0401F517 RID: 128279
		[Token(Token = "0x401F517")]
		[FieldOffset(Offset = "0x40")]
		public bool isStage;

		// Token: 0x0401F518 RID: 128280
		[Token(Token = "0x401F518")]
		[FieldOffset(Offset = "0x44")]
		public int rankNum;

		// Token: 0x0401F519 RID: 128281
		[Token(Token = "0x401F519")]
		[FieldOffset(Offset = "0x48")]
		public bool isSelected;
	}
}
