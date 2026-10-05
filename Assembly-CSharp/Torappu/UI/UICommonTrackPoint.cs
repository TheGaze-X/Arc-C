using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003849 RID: 14409
	[Token(Token = "0x2003849")]
	public class UICommonTrackPoint : DataBinder<TrackPointViewProperty>, LocalTrackStore.IBindLocalTrackStore
	{
		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x06016D45 RID: 93509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003696")]
		protected GameObject trackPoint
		{
			[Token(Token = "0x6016D45")]
			[Address(RVA = "0xF3F720", Offset = "0xF3E320", VA = "0x180F3F720")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016D46 RID: 93510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D46")]
		[Address(RVA = "0xF3F3E0", Offset = "0xF3DFE0", VA = "0x180F3F3E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016D47 RID: 93511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D47")]
		[Address(RVA = "0xF3F320", Offset = "0xF3DF20", VA = "0x180F3F320", Slot = "7")]
		public override void OnValueChanged(TrackPointViewProperty property)
		{
		}

		// Token: 0x06016D48 RID: 93512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D48")]
		[Address(RVA = "0xF3F280", Offset = "0xF3DE80", VA = "0x180F3F280", Slot = "8")]
		[LuaCallCSharp(GenFlag.No)]
		public void OnStateChanged(ITrackPointStatus status)
		{
		}

		// Token: 0x06016D49 RID: 93513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D49")]
		[Address(RVA = "0xF3F510", Offset = "0xF3E110", VA = "0x180F3F510")]
		private void _Set(bool show)
		{
		}

		// Token: 0x06016D4A RID: 93514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D4A")]
		[Address(RVA = "0xF3F1F0", Offset = "0xF3DDF0", VA = "0x180F3F1F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016D4B RID: 93515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D4B")]
		[Address(RVA = "0xF3F6B0", Offset = "0xF3E2B0", VA = "0x180F3F6B0")]
		public UICommonTrackPoint()
		{
		}

		// Token: 0x0401B872 RID: 112754
		[Token(Token = "0x401B872")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _trackPointPrefab;

		// Token: 0x0401B873 RID: 112755
		[Token(Token = "0x401B873")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _pointContainer;

		// Token: 0x0401B874 RID: 112756
		[Token(Token = "0x401B874")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401B875 RID: 112757
		[Token(Token = "0x401B875")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_trackPoint;

		// Token: 0x0401B876 RID: 112758
		[Token(Token = "0x401B876")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trackPoint;

		// Token: 0x0401B877 RID: 112759
		[Token(Token = "0x401B877")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B878 RID: 112760
		[Token(Token = "0x401B878")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401B879 RID: 112761
		[Token(Token = "0x401B879")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x0401B87A RID: 112762
		[Token(Token = "0x401B87A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Set;

		// Token: 0x0401B87B RID: 112763
		[Token(Token = "0x401B87B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B87C RID: 112764
		[Token(Token = "0x401B87C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
