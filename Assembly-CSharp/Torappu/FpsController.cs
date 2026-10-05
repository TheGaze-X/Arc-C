using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	public class FpsController : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06004DED RID: 19949 RVA: 0x0002DD08 File Offset: 0x0002BF08
		[Token(Token = "0x1700020D")]
		public bool lockTargetFps
		{
			[Token(Token = "0x6004DED")]
			[Address(RVA = "0x18826C0", Offset = "0x18812C0", VA = "0x1818826C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x1882120", Offset = "0x1880D20", VA = "0x181882120")]
		private void Start()
		{
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x1881F60", Offset = "0x1880B60", VA = "0x181881F60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x18823A0", Offset = "0x1880FA0", VA = "0x1818823A0")]
		private FpsController.Entity _GenInput()
		{
			return default(FpsController.Entity);
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x1882560", Offset = "0x1881160", VA = "0x181882560")]
		public FpsController()
		{
		}

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly int[] MAX_FPS_STRATEGY_MAP;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _lockTargetFps;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _makeNeverSleep;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Inspect("lockTargetFps")]
		private FpsController.FpsMode _targetFpsMode;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _periodToProfile;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _fpsFontSize;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _fpsFontColor;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rect _fpsRect;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x48")]
		private float m_fpsCountTime;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x4C")]
		private int m_frameCnt;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x50")]
		private float m_lastFps;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x54")]
		private Rect m_overdrawRect;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x68")]
		private ScreenUtil.UISleepBlocker m_blocker;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lockTargetFps;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenInput;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020004DA RID: 1242
		[Token(Token = "0x20004DA")]
		public enum FpsMode
		{
			// Token: 0x04001202 RID: 4610
			[Token(Token = "0x4001202")]
			BATTLE,
			// Token: 0x04001203 RID: 4611
			[Token(Token = "0x4001203")]
			UI,
			// Token: 0x04001204 RID: 4612
			[Token(Token = "0x4001204")]
			BUILDING,
			// Token: 0x04001205 RID: 4613
			[Token(Token = "0x4001205")]
			UNLOCK,
			// Token: 0x04001206 RID: 4614
			[Token(Token = "0x4001206")]
			E_NUM
		}

		// Token: 0x020004DB RID: 1243
		[Token(Token = "0x20004DB")]
		public struct Entity
		{
			// Token: 0x04001207 RID: 4615
			[Token(Token = "0x4001207")]
			[FieldOffset(Offset = "0x0")]
			public int instId;

			// Token: 0x04001208 RID: 4616
			[Token(Token = "0x4001208")]
			[FieldOffset(Offset = "0x4")]
			public bool lockFps;

			// Token: 0x04001209 RID: 4617
			[Token(Token = "0x4001209")]
			[FieldOffset(Offset = "0x8")]
			public FpsController.FpsMode mode;
		}
	}
}
