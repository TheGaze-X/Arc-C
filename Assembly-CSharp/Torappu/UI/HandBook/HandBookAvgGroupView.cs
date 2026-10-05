using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006689 RID: 26249
	[Token(Token = "0x2006689")]
	public class HandBookAvgGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x06025B2E RID: 154414 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025B2F RID: 154415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700594B")]
		public Action<string> onAvgItemClick
		{
			[Token(Token = "0x6025B2E")]
			[Address(RVA = "0x208E1D0", Offset = "0x208CDD0", VA = "0x18208E1D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025B2F")]
			[Address(RVA = "0x208E230", Offset = "0x208CE30", VA = "0x18208E230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025B30 RID: 154416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B30")]
		[Address(RVA = "0x208DED0", Offset = "0x208CAD0", VA = "0x18208DED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025B31 RID: 154417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B31")]
		[Address(RVA = "0x208DC30", Offset = "0x208C830", VA = "0x18208DC30")]
		public void Render(HandBookAvgGroupViewModel groupViewModel)
		{
		}

		// Token: 0x06025B32 RID: 154418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B32")]
		[Address(RVA = "0x208E050", Offset = "0x208CC50", VA = "0x18208E050")]
		private void _OnAvgItemClicked(string storyId)
		{
		}

		// Token: 0x06025B33 RID: 154419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B33")]
		[Address(RVA = "0x208E170", Offset = "0x208CD70", VA = "0x18208E170")]
		public HandBookAvgGroupView()
		{
		}

		// Token: 0x04034F54 RID: 216916
		[Token(Token = "0x4034F54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04034F55 RID: 216917
		[Token(Token = "0x4034F55")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04034F56 RID: 216918
		[Token(Token = "0x4034F56")]
		[FieldOffset(Offset = "0x28")]
		private HandBookAvgGroupView.Adapter m_adapter;

		// Token: 0x04034F57 RID: 216919
		[Token(Token = "0x4034F57")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04034F59 RID: 216921
		[Token(Token = "0x4034F59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onAvgItemClick;

		// Token: 0x04034F5A RID: 216922
		[Token(Token = "0x4034F5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onAvgItemClick;

		// Token: 0x04034F5B RID: 216923
		[Token(Token = "0x4034F5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034F5C RID: 216924
		[Token(Token = "0x4034F5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034F5D RID: 216925
		[Token(Token = "0x4034F5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAvgItemClicked;

		// Token: 0x04034F5E RID: 216926
		[Token(Token = "0x4034F5E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200668A RID: 26250
		[Token(Token = "0x200668A")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700594C RID: 22860
			// (get) Token: 0x06025B34 RID: 154420 RVA: 0x000C8C70 File Offset: 0x000C6E70
			[Token(Token = "0x1700594C")]
			public override int count
			{
				[Token(Token = "0x6025B34")]
				[Address(RVA = "0x20886F0", Offset = "0x20872F0", VA = "0x1820886F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025B35 RID: 154421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025B35")]
			[Address(RVA = "0x2088450", Offset = "0x2087050", VA = "0x182088450", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025B36 RID: 154422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025B36")]
			[Address(RVA = "0x2088690", Offset = "0x2087290", VA = "0x182088690")]
			public Adapter()
			{
			}

			// Token: 0x04034F5F RID: 216927
			[Token(Token = "0x4034F5F")]
			[FieldOffset(Offset = "0x20")]
			public string charId;

			// Token: 0x04034F60 RID: 216928
			[Token(Token = "0x4034F60")]
			[FieldOffset(Offset = "0x28")]
			public List<HandbookAvgData> avgList;

			// Token: 0x04034F61 RID: 216929
			[Token(Token = "0x4034F61")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> onAvgItemClick;

			// Token: 0x04034F62 RID: 216930
			[Token(Token = "0x4034F62")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034F63 RID: 216931
			[Token(Token = "0x4034F63")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04034F64 RID: 216932
			[Token(Token = "0x4034F64")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
