using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE2 RID: 27362
	[Token(Token = "0x2006AE2")]
	public class ArchiveAchievementItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027226 RID: 160294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027226")]
		[Address(RVA = "0x224FE80", Offset = "0x224EA80", VA = "0x18224FE80")]
		public void Render(AchievementItemModel itemModel)
		{
		}

		// Token: 0x06027227 RID: 160295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027227")]
		[Address(RVA = "0x2250100", Offset = "0x224ED00", VA = "0x182250100")]
		public ArchiveAchievementItemView()
		{
		}

		// Token: 0x040375B5 RID: 226741
		[Token(Token = "0x40375B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggleIfCompleted;

		// Token: 0x040375B6 RID: 226742
		[Token(Token = "0x40375B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x040375B7 RID: 226743
		[Token(Token = "0x40375B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x040375B8 RID: 226744
		[Token(Token = "0x40375B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _progress;

		// Token: 0x040375B9 RID: 226745
		[Token(Token = "0x40375B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNameCompleted;

		// Token: 0x040375BA RID: 226746
		[Token(Token = "0x40375BA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDescCompleted;

		// Token: 0x040375BB RID: 226747
		[Token(Token = "0x40375BB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textNameUncompleted;

		// Token: 0x040375BC RID: 226748
		[Token(Token = "0x40375BC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDescUncompleted;

		// Token: 0x040375BD RID: 226749
		[Token(Token = "0x40375BD")]
		private const string BKG_NAME_FORMAT_WITH_DIFFERENT_RARITY = "bkg_item_{0}";

		// Token: 0x040375BE RID: 226750
		[Token(Token = "0x40375BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040375BF RID: 226751
		[Token(Token = "0x40375BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
