using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D9E RID: 28062
	[Token(Token = "0x2006D9E")]
	public class UIActTrackPoint : DataBinder<TrackPointViewProperty>
	{
		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x06027F87 RID: 163719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E76")]
		protected GameObject trackPoint
		{
			[Token(Token = "0x6027F87")]
			[Address(RVA = "0x2344410", Offset = "0x2343010", VA = "0x182344410")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027F88 RID: 163720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F88")]
		[Address(RVA = "0x2344290", Offset = "0x2342E90", VA = "0x182344290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027F89 RID: 163721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F89")]
		[Address(RVA = "0x23440D0", Offset = "0x2342CD0", VA = "0x1823440D0", Slot = "7")]
		public override void OnValueChanged(TrackPointViewProperty property)
		{
		}

		// Token: 0x06027F8A RID: 163722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F8A")]
		[Address(RVA = "0x23443A0", Offset = "0x2342FA0", VA = "0x1823443A0")]
		public UIActTrackPoint()
		{
		}

		// Token: 0x04038A57 RID: 232023
		[Token(Token = "0x4038A57")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _pointContainer;

		// Token: 0x04038A58 RID: 232024
		[Token(Token = "0x4038A58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _customPrefab;

		// Token: 0x04038A59 RID: 232025
		[Token(Token = "0x4038A59")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04038A5A RID: 232026
		[Token(Token = "0x4038A5A")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_trackPoint;

		// Token: 0x04038A5B RID: 232027
		[Token(Token = "0x4038A5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trackPoint;

		// Token: 0x04038A5C RID: 232028
		[Token(Token = "0x4038A5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038A5D RID: 232029
		[Token(Token = "0x4038A5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038A5E RID: 232030
		[Token(Token = "0x4038A5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
