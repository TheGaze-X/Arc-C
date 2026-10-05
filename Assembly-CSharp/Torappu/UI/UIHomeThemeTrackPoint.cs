using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AC4 RID: 15044
	[Token(Token = "0x2003AC4")]
	public class UIHomeThemeTrackPoint : DataBinder<TrackPointViewProperty>
	{
		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x06017BBC RID: 97212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038ED")]
		protected GameObject trackPoint
		{
			[Token(Token = "0x6017BBC")]
			[Address(RVA = "0x100FA50", Offset = "0x100E650", VA = "0x18100FA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017BBD RID: 97213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BBD")]
		[Address(RVA = "0x100F440", Offset = "0x100E040", VA = "0x18100F440")]
		public void SetTrackpoint(GameObject trackPoint)
		{
		}

		// Token: 0x06017BBE RID: 97214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BBE")]
		[Address(RVA = "0x100F560", Offset = "0x100E160", VA = "0x18100F560")]
		private void _InitDefaultTrackPoint()
		{
		}

		// Token: 0x06017BBF RID: 97215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BBF")]
		[Address(RVA = "0x100F360", Offset = "0x100DF60", VA = "0x18100F360", Slot = "7")]
		public override void OnValueChanged(TrackPointViewProperty property)
		{
		}

		// Token: 0x06017BC0 RID: 97216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC0")]
		[Address(RVA = "0x100F680", Offset = "0x100E280", VA = "0x18100F680")]
		private void _Render(ITrackPointModel viewModel)
		{
		}

		// Token: 0x06017BC1 RID: 97217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC1")]
		[Address(RVA = "0x100F2C0", Offset = "0x100DEC0", VA = "0x18100F2C0")]
		public void OnStateChangd(ITrackPointStatus status)
		{
		}

		// Token: 0x06017BC2 RID: 97218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC2")]
		[Address(RVA = "0x100F770", Offset = "0x100E370", VA = "0x18100F770")]
		private void _Set(bool show)
		{
		}

		// Token: 0x06017BC3 RID: 97219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC3")]
		[Address(RVA = "0x100F9E0", Offset = "0x100E5E0", VA = "0x18100F9E0")]
		public UIHomeThemeTrackPoint()
		{
		}

		// Token: 0x0401CA60 RID: 117344
		[Token(Token = "0x401CA60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _trackPointPrefab;

		// Token: 0x0401CA61 RID: 117345
		[Token(Token = "0x401CA61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _pointContainer;

		// Token: 0x0401CA62 RID: 117346
		[Token(Token = "0x401CA62")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401CA63 RID: 117347
		[Token(Token = "0x401CA63")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_trackPoint;

		// Token: 0x0401CA64 RID: 117348
		[Token(Token = "0x401CA64")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_injectTrackPoint;

		// Token: 0x0401CA65 RID: 117349
		[Token(Token = "0x401CA65")]
		[FieldOffset(Offset = "0x48")]
		private bool m_useInjectTrackPoint;

		// Token: 0x0401CA66 RID: 117350
		[Token(Token = "0x401CA66")]
		[FieldOffset(Offset = "0x49")]
		private bool m_cacheState;

		// Token: 0x0401CA67 RID: 117351
		[Token(Token = "0x401CA67")]
		[FieldOffset(Offset = "0x50")]
		private ITrackPointModel m_model;

		// Token: 0x0401CA68 RID: 117352
		[Token(Token = "0x401CA68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trackPoint;

		// Token: 0x0401CA69 RID: 117353
		[Token(Token = "0x401CA69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTrackpoint;

		// Token: 0x0401CA6A RID: 117354
		[Token(Token = "0x401CA6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitDefaultTrackPoint;

		// Token: 0x0401CA6B RID: 117355
		[Token(Token = "0x401CA6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401CA6C RID: 117356
		[Token(Token = "0x401CA6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401CA6D RID: 117357
		[Token(Token = "0x401CA6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateChangd;

		// Token: 0x0401CA6E RID: 117358
		[Token(Token = "0x401CA6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Set;

		// Token: 0x0401CA6F RID: 117359
		[Token(Token = "0x401CA6F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
