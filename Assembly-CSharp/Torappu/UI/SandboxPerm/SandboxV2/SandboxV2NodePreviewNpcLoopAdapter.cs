using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004272 RID: 17010
	[Token(Token = "0x2004272")]
	public class SandboxV2NodePreviewNpcLoopAdapter : LoopScrollAdapter<SandboxV2NodePreviewNpcLoopAdapter.ViewHolder, SandboxV2DungeonNpcViewModel>
	{
		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0601A361 RID: 107361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A362 RID: 107362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E40")]
		public string topicId
		{
			[Token(Token = "0x601A361")]
			[Address(RVA = "0x131F7D0", Offset = "0x131E3D0", VA = "0x18131F7D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A362")]
			[Address(RVA = "0x131F830", Offset = "0x131E430", VA = "0x18131F830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A363 RID: 107363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A363")]
		[Address(RVA = "0x131F3D0", Offset = "0x131DFD0", VA = "0x18131F3D0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601A364 RID: 107364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A364")]
		[Address(RVA = "0x131F4B0", Offset = "0x131E0B0", VA = "0x18131F4B0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2NodePreviewNpcLoopAdapter.ViewHolder holder, SandboxV2DungeonNpcViewModel data)
		{
		}

		// Token: 0x0601A365 RID: 107365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A365")]
		[Address(RVA = "0x131F760", Offset = "0x131E360", VA = "0x18131F760")]
		public SandboxV2NodePreviewNpcLoopAdapter()
		{
		}

		// Token: 0x040212AD RID: 135853
		[Token(Token = "0x40212AD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2NodePreviewNpcItemView _itemPrefab;

		// Token: 0x040212AE RID: 135854
		[Token(Token = "0x40212AE")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_finder;

		// Token: 0x040212B0 RID: 135856
		[Token(Token = "0x40212B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040212B1 RID: 135857
		[Token(Token = "0x40212B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x040212B2 RID: 135858
		[Token(Token = "0x40212B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040212B3 RID: 135859
		[Token(Token = "0x40212B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040212B4 RID: 135860
		[Token(Token = "0x40212B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004273 RID: 17011
		[Token(Token = "0x2004273")]
		public class ViewHolder
		{
			// Token: 0x0601A366 RID: 107366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A366")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040212B5 RID: 135861
			[Token(Token = "0x40212B5")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2NodePreviewNpcItemView view;
		}
	}
}
