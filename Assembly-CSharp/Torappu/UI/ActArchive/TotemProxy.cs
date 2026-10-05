using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ACF RID: 27343
	[Token(Token = "0x2006ACF")]
	public class TotemProxy : ActArchiveCompProxy<ArchiveTotemController>
	{
		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x060271CC RID: 160204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C72")]
		protected override string compType
		{
			[Token(Token = "0x60271CC")]
			[Address(RVA = "0x2260FF0", Offset = "0x225FBF0", VA = "0x182260FF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271CD RID: 160205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271CD")]
		[Address(RVA = "0x2260B70", Offset = "0x225F770", VA = "0x182260B70", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271CE RID: 160206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271CE")]
		[Address(RVA = "0x2260C40", Offset = "0x225F840", VA = "0x182260C40", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271CF RID: 160207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271CF")]
		[Address(RVA = "0x2260E80", Offset = "0x225FA80", VA = "0x182260E80")]
		private void _OnItemClicked(ActArchiveType type, string id)
		{
		}

		// Token: 0x060271D0 RID: 160208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271D0")]
		[Address(RVA = "0x2260F80", Offset = "0x225FB80", VA = "0x182260F80")]
		public TotemProxy()
		{
		}

		// Token: 0x0403753B RID: 226619
		[Token(Token = "0x403753B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403753C RID: 226620
		[Token(Token = "0x403753C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x0403753D RID: 226621
		[Token(Token = "0x403753D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403753E RID: 226622
		[Token(Token = "0x403753E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403753F RID: 226623
		[Token(Token = "0x403753F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
