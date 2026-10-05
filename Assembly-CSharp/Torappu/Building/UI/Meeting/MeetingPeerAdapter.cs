using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D74 RID: 7540
	[Token(Token = "0x2001D74")]
	public class MeetingPeerAdapter : LoopScrollAdapter<MeetingPeerAdapter.ViewHolder, IPeer>
	{
		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BA44 RID: 47684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001699")]
		public IMeetingSession session
		{
			[Token(Token = "0x600BA43")]
			[Address(RVA = "0x337E8B0", Offset = "0x337D4B0", VA = "0x18337E8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600BA44")]
			[Address(RVA = "0x337E910", Offset = "0x337D510", VA = "0x18337E910")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA45")]
		[Address(RVA = "0x337E5D0", Offset = "0x337D1D0", VA = "0x18337E5D0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA46")]
		[Address(RVA = "0x337E690", Offset = "0x337D290", VA = "0x18337E690", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MeetingPeerAdapter.ViewHolder holder, IPeer data)
		{
		}

		// Token: 0x0600BA47 RID: 47687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA47")]
		[Address(RVA = "0x337E830", Offset = "0x337D430", VA = "0x18337E830")]
		public MeetingPeerAdapter()
		{
		}

		// Token: 0x0400B92F RID: 47407
		[Token(Token = "0x400B92F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _peerProto;

		// Token: 0x0400B930 RID: 47408
		[Token(Token = "0x400B930")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _poolTransform;

		// Token: 0x0400B931 RID: 47409
		[Token(Token = "0x400B931")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0400B933 RID: 47411
		[Token(Token = "0x400B933")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_session;

		// Token: 0x0400B934 RID: 47412
		[Token(Token = "0x400B934")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_session;

		// Token: 0x0400B935 RID: 47413
		[Token(Token = "0x400B935")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400B936 RID: 47414
		[Token(Token = "0x400B936")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400B937 RID: 47415
		[Token(Token = "0x400B937")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D75 RID: 7541
		[Token(Token = "0x2001D75")]
		public class ViewHolder
		{
			// Token: 0x0600BA48 RID: 47688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BA48")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}
		}
	}
}
