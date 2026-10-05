using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF3 RID: 19955
	[Token(Token = "0x2004DF3")]
	public class NameCardV2AssistCharItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x0601DD31 RID: 122161 RVA: 0x000AC728 File Offset: 0x000AA928
		[Token(Token = "0x170045FF")]
		public bool isSwitchTweenShow
		{
			[Token(Token = "0x601DD31")]
			[Address(RVA = "0x1758EE0", Offset = "0x1757AE0", VA = "0x181758EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x0601DD32 RID: 122162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004600")]
		public UIColorGraphic clickColorGraphic
		{
			[Token(Token = "0x601DD32")]
			[Address(RVA = "0x1758E80", Offset = "0x1757A80", VA = "0x181758E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DD33 RID: 122163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD33")]
		[Address(RVA = "0x1758360", Offset = "0x1756F60", VA = "0x181758360")]
		public void ApplyFriendData(SharedCharData assist)
		{
		}

		// Token: 0x0601DD34 RID: 122164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD34")]
		[Address(RVA = "0x17582F0", Offset = "0x1756EF0", VA = "0x1817582F0")]
		public void ApplyEmpty()
		{
		}

		// Token: 0x0601DD35 RID: 122165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD35")]
		[Address(RVA = "0x1757D90", Offset = "0x1756990", VA = "0x181757D90")]
		public void ApplyData(PlayerFriendAssist assist)
		{
		}

		// Token: 0x0601DD36 RID: 122166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD36")]
		[Address(RVA = "0x1758770", Offset = "0x1757370", VA = "0x181758770")]
		public void SetTweenShow(bool fastMode, bool isShow)
		{
		}

		// Token: 0x0601DD37 RID: 122167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD37")]
		[Address(RVA = "0x1758930", Offset = "0x1757530", VA = "0x181758930")]
		private void _ApplyData(PlayerCharacter charData, string skillId, string equipId)
		{
		}

		// Token: 0x0601DD38 RID: 122168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD38")]
		[Address(RVA = "0x1758D10", Offset = "0x1757910", VA = "0x181758D10")]
		private void _EnsureSwitchTween()
		{
		}

		// Token: 0x0601DD39 RID: 122169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD39")]
		[Address(RVA = "0x1758E20", Offset = "0x1757A20", VA = "0x181758E20")]
		public NameCardV2AssistCharItem()
		{
		}

		// Token: 0x04027829 RID: 161833
		[Token(Token = "0x4027829")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _emptyToggle;

		// Token: 0x0402782A RID: 161834
		[Token(Token = "0x402782A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _eliteIcon;

		// Token: 0x0402782B RID: 161835
		[Token(Token = "0x402782B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _specMaxPart;

		// Token: 0x0402782C RID: 161836
		[Token(Token = "0x402782C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _portraitIcon;

		// Token: 0x0402782D RID: 161837
		[Token(Token = "0x402782D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _level;

		// Token: 0x0402782E RID: 161838
		[Token(Token = "0x402782E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _potentialLevel;

		// Token: 0x0402782F RID: 161839
		[Token(Token = "0x402782F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x04027830 RID: 161840
		[Token(Token = "0x4027830")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _equipIcon;

		// Token: 0x04027831 RID: 161841
		[Token(Token = "0x4027831")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _equipToggle;

		// Token: 0x04027832 RID: 161842
		[Token(Token = "0x4027832")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04027833 RID: 161843
		[Token(Token = "0x4027833")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIColorGraphic _clickColorGraphic;

		// Token: 0x04027834 RID: 161844
		[Token(Token = "0x4027834")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_switchTween;

		// Token: 0x04027835 RID: 161845
		[Token(Token = "0x4027835")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasTweenInited;

		// Token: 0x04027836 RID: 161846
		[Token(Token = "0x4027836")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSwitchTweenShow;

		// Token: 0x04027837 RID: 161847
		[Token(Token = "0x4027837")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_clickColorGraphic;

		// Token: 0x04027838 RID: 161848
		[Token(Token = "0x4027838")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyFriendData;

		// Token: 0x04027839 RID: 161849
		[Token(Token = "0x4027839")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyEmpty;

		// Token: 0x0402783A RID: 161850
		[Token(Token = "0x402783A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402783B RID: 161851
		[Token(Token = "0x402783B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTweenShow;

		// Token: 0x0402783C RID: 161852
		[Token(Token = "0x402783C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x0402783D RID: 161853
		[Token(Token = "0x402783D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x0402783E RID: 161854
		[Token(Token = "0x402783E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
