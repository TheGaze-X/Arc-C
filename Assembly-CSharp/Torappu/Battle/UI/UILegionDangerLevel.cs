using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003388 RID: 13192
	[Token(Token = "0x2003388")]
	public class UILegionDangerLevel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015097 RID: 86167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015097")]
		[Address(RVA = "0xD782C0", Offset = "0xD76EC0", VA = "0x180D782C0")]
		public void SetData(float interval, int initLevel)
		{
		}

		// Token: 0x06015098 RID: 86168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015098")]
		[Address(RVA = "0xD78480", Offset = "0xD77080", VA = "0x180D78480")]
		public void UpdateData(int dangerLevel, int maxLevel, float progressToNextLevel)
		{
		}

		// Token: 0x06015099 RID: 86169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015099")]
		[Address(RVA = "0xD787C0", Offset = "0xD773C0", VA = "0x180D787C0")]
		public UILegionDangerLevel()
		{
		}

		// Token: 0x04019090 RID: 102544
		[Token(Token = "0x4019090")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x04019091 RID: 102545
		[Token(Token = "0x4019091")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelTextBlack;

		// Token: 0x04019092 RID: 102546
		[Token(Token = "0x4019092")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objMax;

		// Token: 0x04019093 RID: 102547
		[Token(Token = "0x4019093")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _leftSlider;

		// Token: 0x04019094 RID: 102548
		[Token(Token = "0x4019094")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _rightSlider;

		// Token: 0x04019095 RID: 102549
		[Token(Token = "0x4019095")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UILegionDangerLevelEffectHolder _effectHolder;

		// Token: 0x04019096 RID: 102550
		[Token(Token = "0x4019096")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04019097 RID: 102551
		[Token(Token = "0x4019097")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04019098 RID: 102552
		[Token(Token = "0x4019098")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
