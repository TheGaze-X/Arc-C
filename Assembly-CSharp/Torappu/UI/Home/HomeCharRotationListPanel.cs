using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BDB RID: 19419
	[Token(Token = "0x2004BDB")]
	public class HomeCharRotationListPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D2F6 RID: 119542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F6")]
		[Address(RVA = "0x16BFBC0", Offset = "0x16BE7C0", VA = "0x1816BFBC0")]
		public void Render(HomeCharRotationViewModel model, int skinMaxCnt)
		{
		}

		// Token: 0x0601D2F7 RID: 119543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F7")]
		[Address(RVA = "0x16BFA50", Offset = "0x16BE650", VA = "0x1816BFA50")]
		public void OnSetSecretary()
		{
		}

		// Token: 0x0601D2F8 RID: 119544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F8")]
		[Address(RVA = "0x16BFB30", Offset = "0x16BE730", VA = "0x1816BFB30")]
		public void OpenChangeSecretarySkinState()
		{
		}

		// Token: 0x0601D2F9 RID: 119545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F9")]
		[Address(RVA = "0x16BFF90", Offset = "0x16BEB90", VA = "0x1816BFF90")]
		private void _OnClicked(string uniqueSkinTag)
		{
		}

		// Token: 0x0601D2FA RID: 119546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2FA")]
		[Address(RVA = "0x16BFE70", Offset = "0x16BEA70", VA = "0x1816BFE70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D2FB RID: 119547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2FB")]
		[Address(RVA = "0x16C0080", Offset = "0x16BEC80", VA = "0x1816C0080")]
		public HomeCharRotationListPanel()
		{
		}

		// Token: 0x040264F0 RID: 156912
		[Token(Token = "0x40264F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _chosenSkinCount;

		// Token: 0x040264F1 RID: 156913
		[Token(Token = "0x40264F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skinMaxCount;

		// Token: 0x040264F2 RID: 156914
		[Token(Token = "0x40264F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _setAssistToggle;

		// Token: 0x040264F3 RID: 156915
		[Token(Token = "0x40264F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040264F4 RID: 156916
		[Token(Token = "0x40264F4")]
		[FieldOffset(Offset = "0x38")]
		private string m_secretarySkinTag;

		// Token: 0x040264F5 RID: 156917
		[Token(Token = "0x40264F5")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedSkinTag;

		// Token: 0x040264F6 RID: 156918
		[Token(Token = "0x40264F6")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, HomeCharRotationPresetSkinItemViewModel> m_cachedSkinItems;

		// Token: 0x040264F7 RID: 156919
		[Token(Token = "0x40264F7")]
		[FieldOffset(Offset = "0x50")]
		private HomeCharRotationListPanel.Adapter m_adapter;

		// Token: 0x040264F8 RID: 156920
		[Token(Token = "0x40264F8")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x040264F9 RID: 156921
		[Token(Token = "0x40264F9")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040264FA RID: 156922
		[Token(Token = "0x40264FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040264FB RID: 156923
		[Token(Token = "0x40264FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetSecretary;

		// Token: 0x040264FC RID: 156924
		[Token(Token = "0x40264FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenChangeSecretarySkinState;

		// Token: 0x040264FD RID: 156925
		[Token(Token = "0x40264FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClicked;

		// Token: 0x040264FE RID: 156926
		[Token(Token = "0x40264FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040264FF RID: 156927
		[Token(Token = "0x40264FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BDC RID: 19420
		[Token(Token = "0x2004BDC")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D2FC RID: 119548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2FC")]
			[Address(RVA = "0x16B70A0", Offset = "0x16B5CA0", VA = "0x1816B70A0")]
			public Adapter(HomeCharRotationListPanel closure)
			{
			}

			// Token: 0x170044A7 RID: 17575
			// (get) Token: 0x0601D2FD RID: 119549 RVA: 0x000AAD60 File Offset: 0x000A8F60
			[Token(Token = "0x170044A7")]
			public override int count
			{
				[Token(Token = "0x601D2FD")]
				[Address(RVA = "0x16B7490", Offset = "0x16B6090", VA = "0x1816B7490", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D2FE RID: 119550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D2FE")]
			[Address(RVA = "0x16B5CC0", Offset = "0x16B48C0", VA = "0x1816B5CC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026500 RID: 156928
			[Token(Token = "0x4026500")]
			[FieldOffset(Offset = "0x20")]
			private HomeCharRotationListPanel m_closure;

			// Token: 0x04026501 RID: 156929
			[Token(Token = "0x4026501")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026502 RID: 156930
			[Token(Token = "0x4026502")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026503 RID: 156931
			[Token(Token = "0x4026503")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
