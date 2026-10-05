using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BDD RID: 7133
	[Token(Token = "0x2001BDD")]
	public class BuildingWorkshopBonusItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B206 RID: 45574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B206")]
		[Address(RVA = "0x32BB770", Offset = "0x32BA370", VA = "0x1832BB770")]
		public void Render(BonusItemModel model)
		{
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B207")]
		[Address(RVA = "0x32BB990", Offset = "0x32BA590", VA = "0x1832BB990")]
		private Sprite _LoadIcon(string bonusId)
		{
			return null;
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B208")]
		[Address(RVA = "0x32BBB90", Offset = "0x32BA790", VA = "0x1832BBB90")]
		public BuildingWorkshopBonusItem()
		{
		}

		// Token: 0x0400AC98 RID: 44184
		[Token(Token = "0x400AC98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400AC99 RID: 44185
		[Token(Token = "0x400AC99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgProgress;

		// Token: 0x0400AC9A RID: 44186
		[Token(Token = "0x400AC9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0400AC9B RID: 44187
		[Token(Token = "0x400AC9B")]
		[FieldOffset(Offset = "0x30")]
		private BonusItemModel m_curModel;

		// Token: 0x0400AC9C RID: 44188
		[Token(Token = "0x400AC9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AC9D RID: 44189
		[Token(Token = "0x400AC9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadIcon;

		// Token: 0x0400AC9E RID: 44190
		[Token(Token = "0x400AC9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
