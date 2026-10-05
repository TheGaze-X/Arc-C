using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004941 RID: 18753
	[Token(Token = "0x2004941")]
	public class UIMedalDIYValidPosView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x0601C44E RID: 115790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004300")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x601C44E")]
			[Address(RVA = "0x15C0BE0", Offset = "0x15BF7E0", VA = "0x1815C0BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C44F RID: 115791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C44F")]
		[Address(RVA = "0x15C05C0", Offset = "0x15BF1C0", VA = "0x1815C05C0")]
		public void Render(DIYMedalModel model, bool hasValidPos)
		{
		}

		// Token: 0x0601C450 RID: 115792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C450")]
		[Address(RVA = "0x15C0A80", Offset = "0x15BF680", VA = "0x1815C0A80")]
		private void _SetActive(bool hasValidPos)
		{
		}

		// Token: 0x0601C451 RID: 115793 RVA: 0x000A7BC8 File Offset: 0x000A5DC8
		[Token(Token = "0x601C451")]
		[Address(RVA = "0x15C08F0", Offset = "0x15BF4F0", VA = "0x1815C08F0")]
		private UIMedalDIYValidPosView.SizeConfig _GetSizeConfig(MedalSize size)
		{
			return default(UIMedalDIYValidPosView.SizeConfig);
		}

		// Token: 0x0601C452 RID: 115794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C452")]
		[Address(RVA = "0x15C0B80", Offset = "0x15BF780", VA = "0x1815C0B80")]
		public UIMedalDIYValidPosView()
		{
		}

		// Token: 0x04024FAF RID: 151471
		[Token(Token = "0x4024FAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _img;

		// Token: 0x04024FB0 RID: 151472
		[Token(Token = "0x4024FB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04024FB1 RID: 151473
		[Token(Token = "0x4024FB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIMedalDIYValidPosView.SizeConfig> _sizeConfigs;

		// Token: 0x04024FB2 RID: 151474
		[Token(Token = "0x4024FB2")]
		[FieldOffset(Offset = "0x30")]
		private DIYMedalModel m_model;

		// Token: 0x04024FB3 RID: 151475
		[Token(Token = "0x4024FB3")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x04024FB4 RID: 151476
		[Token(Token = "0x4024FB4")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform m_rectTrans;

		// Token: 0x04024FB5 RID: 151477
		[Token(Token = "0x4024FB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x04024FB6 RID: 151478
		[Token(Token = "0x4024FB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024FB7 RID: 151479
		[Token(Token = "0x4024FB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetActive;

		// Token: 0x04024FB8 RID: 151480
		[Token(Token = "0x4024FB8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetSizeConfig;

		// Token: 0x04024FB9 RID: 151481
		[Token(Token = "0x4024FB9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004942 RID: 18754
		[Token(Token = "0x2004942")]
		[Serializable]
		private struct SizeConfig
		{
			// Token: 0x04024FBA RID: 151482
			[Token(Token = "0x4024FBA")]
			[FieldOffset(Offset = "0x0")]
			public MedalSize size;

			// Token: 0x04024FBB RID: 151483
			[Token(Token = "0x4024FBB")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 imgSize;
		}
	}
}
