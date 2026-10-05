using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004428 RID: 17448
	[Token(Token = "0x2004428")]
	public class SandboxV2SquadButtonView : DataBinder<SandboxV2SquadGroupProp>
	{
		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0601AA5C RID: 109148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA5D RID: 109149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F28")]
		public Action<int> onSquadTabClick
		{
			[Token(Token = "0x601AA5C")]
			[Address(RVA = "0x13C2FF0", Offset = "0x13C1BF0", VA = "0x1813C2FF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA5D")]
			[Address(RVA = "0x13C3050", Offset = "0x13C1C50", VA = "0x1813C3050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA5E RID: 109150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA5E")]
		[Address(RVA = "0x13C2A70", Offset = "0x13C1670", VA = "0x1813C2A70", Slot = "7")]
		public override void OnValueChanged(SandboxV2SquadGroupProp property)
		{
		}

		// Token: 0x0601AA5F RID: 109151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA5F")]
		[Address(RVA = "0x13C2C70", Offset = "0x13C1870", VA = "0x1813C2C70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AA60 RID: 109152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA60")]
		[Address(RVA = "0x13C2EA0", Offset = "0x13C1AA0", VA = "0x1813C2EA0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x0601AA61 RID: 109153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA61")]
		[Address(RVA = "0x13C2F80", Offset = "0x13C1B80", VA = "0x1813C2F80")]
		public SandboxV2SquadButtonView()
		{
		}

		// Token: 0x04022005 RID: 139269
		[Token(Token = "0x4022005")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _repoBtnGo;

		// Token: 0x04022006 RID: 139270
		[Token(Token = "0x4022006")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _repoUnselectGo;

		// Token: 0x04022007 RID: 139271
		[Token(Token = "0x4022007")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _repoSelectGo;

		// Token: 0x04022008 RID: 139272
		[Token(Token = "0x4022008")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _squadTabGraphic;

		// Token: 0x04022009 RID: 139273
		[Token(Token = "0x4022009")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _squadBtnList;

		// Token: 0x0402200A RID: 139274
		[Token(Token = "0x402200A")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402200B RID: 139275
		[Token(Token = "0x402200B")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2SquadButtonView.SquadBtnListAdapter m_squadListAdapter;

		// Token: 0x0402200D RID: 139277
		[Token(Token = "0x402200D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSquadTabClick;

		// Token: 0x0402200E RID: 139278
		[Token(Token = "0x402200E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSquadTabClick;

		// Token: 0x0402200F RID: 139279
		[Token(Token = "0x402200F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022010 RID: 139280
		[Token(Token = "0x4022010")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022011 RID: 139281
		[Token(Token = "0x4022011")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04022012 RID: 139282
		[Token(Token = "0x4022012")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004429 RID: 17449
		[Token(Token = "0x2004429")]
		private class SquadBtnListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AA62 RID: 109154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AA62")]
			[Address(RVA = "0x13D4850", Offset = "0x13D3450", VA = "0x1813D4850")]
			public SquadBtnListAdapter(Action<int> onItemClick)
			{
			}

			// Token: 0x17003F29 RID: 16169
			// (get) Token: 0x0601AA63 RID: 109155 RVA: 0x000A2B10 File Offset: 0x000A0D10
			[Token(Token = "0x17003F29")]
			public override int count
			{
				[Token(Token = "0x601AA63")]
				[Address(RVA = "0x13D48D0", Offset = "0x13D34D0", VA = "0x1813D48D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AA64 RID: 109156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AA64")]
			[Address(RVA = "0x13D4610", Offset = "0x13D3210", VA = "0x1813D4610")]
			public void UpdateData(SandboxV2SquadGroupModel squadGroupModel)
			{
			}

			// Token: 0x0601AA65 RID: 109157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AA65")]
			[Address(RVA = "0x13D40E0", Offset = "0x13D2CE0", VA = "0x1813D40E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AA66 RID: 109158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AA66")]
			[Address(RVA = "0x13D4690", Offset = "0x13D3290", VA = "0x1813D4690")]
			private void _RegisterTutorialGo(int index, SandboxV2SquadTabItemView itemView)
			{
			}

			// Token: 0x04022013 RID: 139283
			[Token(Token = "0x4022013")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2SquadGroupModel m_squadGroupModel;

			// Token: 0x04022014 RID: 139284
			[Token(Token = "0x4022014")]
			[FieldOffset(Offset = "0x28")]
			private Action<int> m_onItemClick;

			// Token: 0x04022015 RID: 139285
			[Token(Token = "0x4022015")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022016 RID: 139286
			[Token(Token = "0x4022016")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022017 RID: 139287
			[Token(Token = "0x4022017")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04022018 RID: 139288
			[Token(Token = "0x4022018")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022019 RID: 139289
			[Token(Token = "0x4022019")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RegisterTutorialGo;
		}
	}
}
