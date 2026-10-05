using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200559F RID: 21919
	[Token(Token = "0x200559F")]
	public class RL05FreezeCopperListLoopAdapter : LoopScrollAdapter<RL05FreezeCopperListLoopAdapter.ViewHolder, RoguelikePlayerCopperItemViewModel>
	{
		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x06020310 RID: 131856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020311 RID: 131857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B7F")]
		public List<string> selectedInstId
		{
			[Token(Token = "0x6020310")]
			[Address(RVA = "0x1A53AA0", Offset = "0x1A526A0", VA = "0x181A53AA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020311")]
			[Address(RVA = "0x1A53BD0", Offset = "0x1A527D0", VA = "0x181A53BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x06020312 RID: 131858 RVA: 0x000B4E40 File Offset: 0x000B3040
		// (set) Token: 0x06020313 RID: 131859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B80")]
		public bool isMax
		{
			[Token(Token = "0x6020312")]
			[Address(RVA = "0x1A53A40", Offset = "0x1A52640", VA = "0x181A53A40")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6020313")]
			[Address(RVA = "0x1A53B60", Offset = "0x1A52760", VA = "0x181A53B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x06020314 RID: 131860 RVA: 0x000B4E58 File Offset: 0x000B3058
		// (set) Token: 0x06020315 RID: 131861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B81")]
		public int sequenceNum
		{
			[Token(Token = "0x6020314")]
			[Address(RVA = "0x1A53B00", Offset = "0x1A52700", VA = "0x181A53B00")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x6020315")]
			[Address(RVA = "0x1A53C50", Offset = "0x1A52850", VA = "0x181A53C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020316 RID: 131862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020316")]
		[Address(RVA = "0x1A53560", Offset = "0x1A52160", VA = "0x181A53560", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06020317 RID: 131863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020317")]
		[Address(RVA = "0x1A53750", Offset = "0x1A52350", VA = "0x181A53750", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RL05FreezeCopperListLoopAdapter.ViewHolder holder, RoguelikePlayerCopperItemViewModel data)
		{
		}

		// Token: 0x06020318 RID: 131864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020318")]
		[Address(RVA = "0x1A53610", Offset = "0x1A52210", VA = "0x181A53610", Slot = "9")]
		protected override void OnNewItemAlloc(GameObject newItem)
		{
		}

		// Token: 0x06020319 RID: 131865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020319")]
		[Address(RVA = "0x1A539D0", Offset = "0x1A525D0", VA = "0x181A539D0")]
		public RL05FreezeCopperListLoopAdapter()
		{
		}

		// Token: 0x0602031A RID: 131866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602031A")]
		[Address(RVA = "0x138F8E0", Offset = "0x138E4E0", VA = "0x18138F8E0")]
		private void <>xLuaBaseProxy_OnNewItemAlloc(GameObject P0)
		{
		}

		// Token: 0x0402B84E RID: 178254
		[Token(Token = "0x402B84E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0402B852 RID: 178258
		[Token(Token = "0x402B852")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedInstId;

		// Token: 0x0402B853 RID: 178259
		[Token(Token = "0x402B853")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedInstId;

		// Token: 0x0402B854 RID: 178260
		[Token(Token = "0x402B854")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMax;

		// Token: 0x0402B855 RID: 178261
		[Token(Token = "0x402B855")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isMax;

		// Token: 0x0402B856 RID: 178262
		[Token(Token = "0x402B856")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sequenceNum;

		// Token: 0x0402B857 RID: 178263
		[Token(Token = "0x402B857")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sequenceNum;

		// Token: 0x0402B858 RID: 178264
		[Token(Token = "0x402B858")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402B859 RID: 178265
		[Token(Token = "0x402B859")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402B85A RID: 178266
		[Token(Token = "0x402B85A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnNewItemAlloc;

		// Token: 0x0402B85B RID: 178267
		[Token(Token = "0x402B85B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055A0 RID: 21920
		[Token(Token = "0x20055A0")]
		public class ViewHolder
		{
			// Token: 0x0602031B RID: 131867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602031B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402B85C RID: 178268
			[Token(Token = "0x402B85C")]
			[FieldOffset(Offset = "0x10")]
			public RL05FreezeCopperItemView view;
		}
	}
}
