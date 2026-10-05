using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FCD RID: 16333
	[Token(Token = "0x2003FCD")]
	public class PCKeyCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601951F RID: 103711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601951F")]
		[Address(RVA = "0x11F9370", Offset = "0x11F7F70", VA = "0x1811F9370")]
		public void SetScaler(float scale)
		{
		}

		// Token: 0x06019520 RID: 103712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019520")]
		[Address(RVA = "0x11F9280", Offset = "0x11F7E80", VA = "0x1811F9280")]
		public void SetCallBack(Action onKeyCardClick)
		{
		}

		// Token: 0x06019521 RID: 103713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019521")]
		[Address(RVA = "0x11F8F40", Offset = "0x11F7B40", VA = "0x1811F8F40")]
		public void Render(KeyItem key, bool isSetting = false, bool cannotSet = false)
		{
		}

		// Token: 0x06019522 RID: 103714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019522")]
		[Address(RVA = "0x11F9760", Offset = "0x11F8360", VA = "0x1811F9760")]
		private void _RenderKey(KeyItem key, PCKeyCard.KeyState keyState)
		{
		}

		// Token: 0x06019523 RID: 103715 RVA: 0x0009DBA8 File Offset: 0x0009BDA8
		[Token(Token = "0x6019523")]
		[Address(RVA = "0x11F9420", Offset = "0x11F8020", VA = "0x1811F9420")]
		private PCKeyCard.IconConfig _FindKeyIconConfig(string keyId)
		{
			return default(PCKeyCard.IconConfig);
		}

		// Token: 0x06019524 RID: 103716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019524")]
		[Address(RVA = "0x11F9600", Offset = "0x11F8200", VA = "0x1811F9600")]
		private void _RenderKeyIconState(PCKeyCard.IconConfig iconConfig, PCKeyCard.KeyState keysState)
		{
		}

		// Token: 0x06019525 RID: 103717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019525")]
		[Address(RVA = "0x11F8ED0", Offset = "0x11F7AD0", VA = "0x1811F8ED0")]
		public void OnKeyCardClick()
		{
		}

		// Token: 0x06019526 RID: 103718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019526")]
		[Address(RVA = "0x11F8E60", Offset = "0x11F7A60", VA = "0x1811F8E60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019527 RID: 103719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019527")]
		[Address(RVA = "0x11F9AC0", Offset = "0x11F86C0", VA = "0x1811F9AC0")]
		public PCKeyCard()
		{
		}

		// Token: 0x0401F76D RID: 128877
		[Token(Token = "0x401F76D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401F76E RID: 128878
		[Token(Token = "0x401F76E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x0401F76F RID: 128879
		[Token(Token = "0x401F76F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnBgDefault;

		// Token: 0x0401F770 RID: 128880
		[Token(Token = "0x401F770")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnBgCannotSet;

		// Token: 0x0401F771 RID: 128881
		[Token(Token = "0x401F771")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnBgSetting;

		// Token: 0x0401F772 RID: 128882
		[Token(Token = "0x401F772")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _keyName;

		// Token: 0x0401F773 RID: 128883
		[Token(Token = "0x401F773")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0401F774 RID: 128884
		[Token(Token = "0x401F774")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PCKeyCard.IconConfig[] _iconConfigs;

		// Token: 0x0401F775 RID: 128885
		[Token(Token = "0x401F775")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0401F776 RID: 128886
		[Token(Token = "0x401F776")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedKeyId;

		// Token: 0x0401F777 RID: 128887
		[Token(Token = "0x401F777")]
		[FieldOffset(Offset = "0x68")]
		private PCKeyCard.KeyState m_keyState;

		// Token: 0x0401F778 RID: 128888
		[Token(Token = "0x401F778")]
		[FieldOffset(Offset = "0x70")]
		private Action m_onKeyCardClick;

		// Token: 0x0401F779 RID: 128889
		[Token(Token = "0x401F779")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x0401F77A RID: 128890
		[Token(Token = "0x401F77A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCallBack;

		// Token: 0x0401F77B RID: 128891
		[Token(Token = "0x401F77B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F77C RID: 128892
		[Token(Token = "0x401F77C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderKey;

		// Token: 0x0401F77D RID: 128893
		[Token(Token = "0x401F77D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindKeyIconConfig;

		// Token: 0x0401F77E RID: 128894
		[Token(Token = "0x401F77E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderKeyIconState;

		// Token: 0x0401F77F RID: 128895
		[Token(Token = "0x401F77F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnKeyCardClick;

		// Token: 0x0401F780 RID: 128896
		[Token(Token = "0x401F780")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401F781 RID: 128897
		[Token(Token = "0x401F781")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FCE RID: 16334
		[Token(Token = "0x2003FCE")]
		private enum KeyState
		{
			// Token: 0x0401F783 RID: 128899
			[Token(Token = "0x401F783")]
			NONE,
			// Token: 0x0401F784 RID: 128900
			[Token(Token = "0x401F784")]
			NORMAL,
			// Token: 0x0401F785 RID: 128901
			[Token(Token = "0x401F785")]
			CANNOT_SET,
			// Token: 0x0401F786 RID: 128902
			[Token(Token = "0x401F786")]
			SETTING
		}

		// Token: 0x02003FCF RID: 16335
		[Token(Token = "0x2003FCF")]
		[Serializable]
		private struct IconConfig
		{
			// Token: 0x0401F787 RID: 128903
			[Token(Token = "0x401F787")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PCKeyCard.IconConfig EMPTY;

			// Token: 0x0401F788 RID: 128904
			[Token(Token = "0x401F788")]
			[FieldOffset(Offset = "0x0")]
			public string keyId;

			// Token: 0x0401F789 RID: 128905
			[Token(Token = "0x401F789")]
			[FieldOffset(Offset = "0x8")]
			public GameObject icon;

			// Token: 0x0401F78A RID: 128906
			[Token(Token = "0x401F78A")]
			[FieldOffset(Offset = "0x10")]
			public bool hideBg;

			// Token: 0x0401F78B RID: 128907
			[Token(Token = "0x401F78B")]
			[FieldOffset(Offset = "0x18")]
			public GameObject iconNormal;

			// Token: 0x0401F78C RID: 128908
			[Token(Token = "0x401F78C")]
			[FieldOffset(Offset = "0x20")]
			public GameObject iconCannotSet;

			// Token: 0x0401F78D RID: 128909
			[Token(Token = "0x401F78D")]
			[FieldOffset(Offset = "0x28")]
			public GameObject iconSetting;
		}
	}
}
