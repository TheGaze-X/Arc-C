using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC1 RID: 27329
	[Token(Token = "0x2006AC1")]
	public class ActivityEntryProxy : ActArchiveCompProxy<ArchiveActivityEntryController>
	{
		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x0602717E RID: 160126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C64")]
		protected override string compType
		{
			[Token(Token = "0x602717E")]
			[Address(RVA = "0x2235C80", Offset = "0x2234880", VA = "0x182235C80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602717F RID: 160127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602717F")]
		[Address(RVA = "0x2235430", Offset = "0x2234030", VA = "0x182235430")]
		public void BindEffectToPage(UICommonPageEffectHolder effectHolder)
		{
		}

		// Token: 0x06027180 RID: 160128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027180")]
		[Address(RVA = "0x2235360", Offset = "0x2233F60", VA = "0x182235360")]
		public void BindCanvasToPage(Canvas canvas)
		{
		}

		// Token: 0x06027181 RID: 160129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027181")]
		[Address(RVA = "0x2235610", Offset = "0x2234210", VA = "0x182235610", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x06027182 RID: 160130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027182")]
		[Address(RVA = "0x2235540", Offset = "0x2234140", VA = "0x182235540", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027183 RID: 160131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027183")]
		[Address(RVA = "0x2235A00", Offset = "0x2234600", VA = "0x182235A00")]
		private void _onEntryItemClicked(ActArchiveType archiveItemType)
		{
		}

		// Token: 0x06027184 RID: 160132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027184")]
		[Address(RVA = "0x2235990", Offset = "0x2234590", VA = "0x182235990")]
		public ActivityEntryProxy()
		{
		}

		// Token: 0x040374EC RID: 226540
		[Token(Token = "0x40374EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374ED RID: 226541
		[Token(Token = "0x40374ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindEffectToPage;

		// Token: 0x040374EE RID: 226542
		[Token(Token = "0x40374EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindCanvasToPage;

		// Token: 0x040374EF RID: 226543
		[Token(Token = "0x40374EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374F0 RID: 226544
		[Token(Token = "0x40374F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374F1 RID: 226545
		[Token(Token = "0x40374F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__onEntryItemClicked;

		// Token: 0x040374F2 RID: 226546
		[Token(Token = "0x40374F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
