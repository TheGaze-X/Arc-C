using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B8 RID: 13240
	[Token(Token = "0x20033B8")]
	public class UIBattleSandboxConstructItemPair : ConstructCommonUIBase
	{
		// Token: 0x06015220 RID: 86560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015220")]
		[Address(RVA = "0xD892F0", Offset = "0xD87EF0", VA = "0x180D892F0")]
		public void Render(UIBattleSandboxConstructItemPair.SandboxConstructItemPairModel model)
		{
		}

		// Token: 0x06015221 RID: 86561 RVA: 0x0008A7F8 File Offset: 0x000889F8
		[Token(Token = "0x6015221")]
		[Address(RVA = "0xD89B30", Offset = "0xD88730", VA = "0x180D89B30")]
		private Color _GetColor(UIBattleSandboxConstructItemPair.SandboxConstructItemPairModel model)
		{
			return default(Color);
		}

		// Token: 0x06015222 RID: 86562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015222")]
		[Address(RVA = "0xD89E30", Offset = "0xD88A30", VA = "0x180D89E30")]
		private Sprite _GetIcon(string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x06015223 RID: 86563 RVA: 0x0008A810 File Offset: 0x00088A10
		[Token(Token = "0x6015223")]
		[Address(RVA = "0xD89C70", Offset = "0xD88870", VA = "0x180D89C70")]
		private Color _GetIconColor(string topicId, string itemId, float alpha)
		{
			return default(Color);
		}

		// Token: 0x06015224 RID: 86564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015224")]
		[Address(RVA = "0xD89FA0", Offset = "0xD88BA0", VA = "0x180D89FA0")]
		private string _GetText(UIBattleSandboxConstructItemPair.SandboxConstructItemPairModel model)
		{
			return null;
		}

		// Token: 0x06015225 RID: 86565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015225")]
		[Address(RVA = "0xD8A090", Offset = "0xD88C90", VA = "0x180D8A090")]
		private void _RenterTextTween(UIBattleSandboxConstructItemPair.SandboxConstructItemPairModel model)
		{
		}

		// Token: 0x06015226 RID: 86566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015226")]
		[Address(RVA = "0xD8A430", Offset = "0xD89030", VA = "0x180D8A430")]
		public UIBattleSandboxConstructItemPair()
		{
		}

		// Token: 0x04019300 RID: 103168
		[Token(Token = "0x4019300")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _alwwaysShowNormalColor;

		// Token: 0x04019301 RID: 103169
		[Token(Token = "0x4019301")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _doNotUseIconColor;

		// Token: 0x04019302 RID: 103170
		[Token(Token = "0x4019302")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x04019303 RID: 103171
		[Token(Token = "0x4019303")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _valueTxt;

		// Token: 0x04019304 RID: 103172
		[Token(Token = "0x4019304")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x04019305 RID: 103173
		[Token(Token = "0x4019305")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _notEnoughColor;

		// Token: 0x04019306 RID: 103174
		[Token(Token = "0x4019306")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _addColor;

		// Token: 0x04019307 RID: 103175
		[Token(Token = "0x4019307")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x04019308 RID: 103176
		[Token(Token = "0x4019308")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Ease _tweenEase;

		// Token: 0x04019309 RID: 103177
		[Token(Token = "0x4019309")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _enableImg;

		// Token: 0x0401930A RID: 103178
		[Token(Token = "0x401930A")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _maxVal;

		// Token: 0x0401930B RID: 103179
		[Token(Token = "0x401930B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _maxValText;

		// Token: 0x0401930C RID: 103180
		[Token(Token = "0x401930C")]
		[FieldOffset(Offset = "0x78")]
		private int m_oldVal;

		// Token: 0x0401930D RID: 103181
		[Token(Token = "0x401930D")]
		[FieldOffset(Offset = "0x7C")]
		private int m_targetVal;

		// Token: 0x0401930E RID: 103182
		[Token(Token = "0x401930E")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_tween;

		// Token: 0x0401930F RID: 103183
		[Token(Token = "0x401930F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019310 RID: 103184
		[Token(Token = "0x4019310")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetColor;

		// Token: 0x04019311 RID: 103185
		[Token(Token = "0x4019311")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetIcon;

		// Token: 0x04019312 RID: 103186
		[Token(Token = "0x4019312")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetIconColor;

		// Token: 0x04019313 RID: 103187
		[Token(Token = "0x4019313")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetText;

		// Token: 0x04019314 RID: 103188
		[Token(Token = "0x4019314")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenterTextTween;

		// Token: 0x04019315 RID: 103189
		[Token(Token = "0x4019315")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033B9 RID: 13241
		[Token(Token = "0x20033B9")]
		public struct SandboxConstructItemPairModel
		{
			// Token: 0x04019316 RID: 103190
			[Token(Token = "0x4019316")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04019317 RID: 103191
			[Token(Token = "0x4019317")]
			[FieldOffset(Offset = "0x8")]
			public string itemId;

			// Token: 0x04019318 RID: 103192
			[Token(Token = "0x4019318")]
			[FieldOffset(Offset = "0x10")]
			public int value;

			// Token: 0x04019319 RID: 103193
			[Token(Token = "0x4019319")]
			[FieldOffset(Offset = "0x14")]
			public bool displayAdd;

			// Token: 0x0401931A RID: 103194
			[Token(Token = "0x401931A")]
			[FieldOffset(Offset = "0x18")]
			public float alpha;
		}
	}
}
