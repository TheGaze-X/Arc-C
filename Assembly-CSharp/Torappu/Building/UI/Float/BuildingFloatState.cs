using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DDA RID: 7642
	[Token(Token = "0x2001DDA")]
	public abstract class BuildingFloatState : MonoBehaviour, IHotfixable
	{
		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x0600BC7F RID: 48255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BC80 RID: 48256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016CC")]
		private protected RoomSlotModel activeSelectedRoom
		{
			[Token(Token = "0x600BC7F")]
			[Address(RVA = "0x33A3860", Offset = "0x33A2460", VA = "0x1833A3860")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600BC80")]
			[Address(RVA = "0x33A3A90", Offset = "0x33A2690", VA = "0x1833A3A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600BC81 RID: 48257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC81")]
		[Address(RVA = "0x33A29D0", Offset = "0x33A15D0", VA = "0x1833A29D0")]
		public void Init(BuildingFloatPage page)
		{
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC82")]
		[Address(RVA = "0x33A2D00", Offset = "0x33A1900", VA = "0x1833A2D00")]
		public void OnStateChanged(FloatState target)
		{
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC83")]
		[Address(RVA = "0x33A3220", Offset = "0x33A1E20", VA = "0x1833A3220")]
		public void OnStateUpdated(FloatState target)
		{
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CD")]
		protected BuildingFloatPage page
		{
			[Token(Token = "0x600BC84")]
			[Address(RVA = "0x33A3980", Offset = "0x33A2580", VA = "0x1833A3980")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x0600BC85 RID: 48261 RVA: 0x000462A8 File Offset: 0x000444A8
		[Token(Token = "0x170016CE")]
		protected BuildingFloatState.PROC proc
		{
			[Token(Token = "0x600BC85")]
			[Address(RVA = "0x33A39E0", Offset = "0x33A25E0", VA = "0x1833A39E0")]
			get
			{
				return BuildingFloatState.PROC.NONE;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CF")]
		protected CanvasGroup canvasGroup
		{
			[Token(Token = "0x600BC86")]
			[Address(RVA = "0x33A38C0", Offset = "0x33A24C0", VA = "0x1833A38C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x0600BC87 RID: 48263 RVA: 0x000462C0 File Offset: 0x000444C0
		[Token(Token = "0x170016D0")]
		protected bool isStateActive
		{
			[Token(Token = "0x600BC87")]
			[Address(RVA = "0x33A3920", Offset = "0x33A2520", VA = "0x1833A3920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x0600BC88 RID: 48264
		[Token(Token = "0x170016D1")]
		protected abstract FloatState state { [Token(Token = "0x600BC88")] get; }

		// Token: 0x0600BC89 RID: 48265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC89")]
		[Address(RVA = "0x33A2C40", Offset = "0x33A1840", VA = "0x1833A2C40", Slot = "5")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0600BC8A RID: 48266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8A")]
		[Address(RVA = "0x33A2B20", Offset = "0x33A1720", VA = "0x1833A2B20", Slot = "6")]
		protected virtual void OnEnter()
		{
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8B")]
		[Address(RVA = "0x33A2B80", Offset = "0x33A1780", VA = "0x1833A2B80", Slot = "7")]
		protected virtual void OnExit()
		{
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8C")]
		[Address(RVA = "0x33A31C0", Offset = "0x33A1DC0", VA = "0x1833A31C0", Slot = "8")]
		protected virtual void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8D")]
		[Address(RVA = "0x33A3160", Offset = "0x33A1D60", VA = "0x1833A3160", Slot = "9")]
		protected virtual void OnStateFocusUpdate()
		{
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8E")]
		[Address(RVA = "0x33A2BE0", Offset = "0x33A17E0", VA = "0x1833A2BE0", Slot = "10")]
		public virtual void OnHandleSignal(string signal)
		{
		}

		// Token: 0x0600BC8F RID: 48271 RVA: 0x000462D8 File Offset: 0x000444D8
		[Token(Token = "0x600BC8F")]
		[Address(RVA = "0x33A2940", Offset = "0x33A1540", VA = "0x1833A2940", Slot = "11")]
		protected virtual bool CheckIfToActive(FloatState targetState)
		{
			return default(bool);
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC90")]
		[Address(RVA = "0x33A2AC0", Offset = "0x33A16C0", VA = "0x1833A2AC0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600BC91 RID: 48273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC91")]
		[Address(RVA = "0x33A2CA0", Offset = "0x33A18A0", VA = "0x1833A2CA0", Slot = "13")]
		protected virtual void OnProcIn()
		{
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC92")]
		[Address(RVA = "0x33A3540", Offset = "0x33A2140", VA = "0x1833A3540")]
		private void _TryTransIn()
		{
		}

		// Token: 0x0600BC93 RID: 48275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC93")]
		[Address(RVA = "0x33A36A0", Offset = "0x33A22A0", VA = "0x1833A36A0")]
		private void _TryTransOut()
		{
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC94")]
		[Address(RVA = "0x33A33E0", Offset = "0x33A1FE0", VA = "0x1833A33E0")]
		private IEnumerator _TransInCoroutine()
		{
			return null;
		}

		// Token: 0x0600BC95 RID: 48277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC95")]
		[Address(RVA = "0x33A3490", Offset = "0x33A2090", VA = "0x1833A3490")]
		private IEnumerator _TransOutCoroutine()
		{
			return null;
		}

		// Token: 0x0600BC96 RID: 48278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC96")]
		[Address(RVA = "0x33A32E0", Offset = "0x33A1EE0", VA = "0x1833A32E0")]
		private static RoomSlotModel _CalcCurrentSelectedRoom()
		{
			return null;
		}

		// Token: 0x0600BC97 RID: 48279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC97")]
		[Address(RVA = "0x33A3800", Offset = "0x33A2400", VA = "0x1833A3800")]
		protected BuildingFloatState()
		{
		}

		// Token: 0x0400BC94 RID: 48276
		[Token(Token = "0x400BC94")]
		private const float ANIM_DURATION = 0.15f;

		// Token: 0x0400BC95 RID: 48277
		[Token(Token = "0x400BC95")]
		[FieldOffset(Offset = "0x18")]
		private BuildingFloatState.PROC m_proc;

		// Token: 0x0400BC96 RID: 48278
		[Token(Token = "0x400BC96")]
		[FieldOffset(Offset = "0x20")]
		private BuildingFloatPage m_page;

		// Token: 0x0400BC97 RID: 48279
		[Token(Token = "0x400BC97")]
		[FieldOffset(Offset = "0x28")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400BC98 RID: 48280
		[Token(Token = "0x400BC98")]
		[FieldOffset(Offset = "0x30")]
		private bool m_interruptTransIn;

		// Token: 0x0400BC99 RID: 48281
		[Token(Token = "0x400BC99")]
		[FieldOffset(Offset = "0x31")]
		private bool m_interruptTransOut;

		// Token: 0x0400BC9A RID: 48282
		[Token(Token = "0x400BC9A")]
		[FieldOffset(Offset = "0x32")]
		private bool m_isStateActive;

		// Token: 0x0400BC9C RID: 48284
		[Token(Token = "0x400BC9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activeSelectedRoom;

		// Token: 0x0400BC9D RID: 48285
		[Token(Token = "0x400BC9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activeSelectedRoom;

		// Token: 0x0400BC9E RID: 48286
		[Token(Token = "0x400BC9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400BC9F RID: 48287
		[Token(Token = "0x400BC9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x0400BCA0 RID: 48288
		[Token(Token = "0x400BCA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BCA1 RID: 48289
		[Token(Token = "0x400BCA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0400BCA2 RID: 48290
		[Token(Token = "0x400BCA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_proc;

		// Token: 0x0400BCA3 RID: 48291
		[Token(Token = "0x400BCA3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0400BCA4 RID: 48292
		[Token(Token = "0x400BCA4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isStateActive;

		// Token: 0x0400BCA5 RID: 48293
		[Token(Token = "0x400BCA5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BCA6 RID: 48294
		[Token(Token = "0x400BCA6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BCA7 RID: 48295
		[Token(Token = "0x400BCA7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BCA8 RID: 48296
		[Token(Token = "0x400BCA8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_OnStateUpdated;

		// Token: 0x0400BCA9 RID: 48297
		[Token(Token = "0x400BCA9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStateFocusUpdate;

		// Token: 0x0400BCAA RID: 48298
		[Token(Token = "0x400BCAA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnHandleSignal;

		// Token: 0x0400BCAB RID: 48299
		[Token(Token = "0x400BCAB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfToActive;

		// Token: 0x0400BCAC RID: 48300
		[Token(Token = "0x400BCAC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400BCAD RID: 48301
		[Token(Token = "0x400BCAD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnProcIn;

		// Token: 0x0400BCAE RID: 48302
		[Token(Token = "0x400BCAE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryTransIn;

		// Token: 0x0400BCAF RID: 48303
		[Token(Token = "0x400BCAF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryTransOut;

		// Token: 0x0400BCB0 RID: 48304
		[Token(Token = "0x400BCB0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TransInCoroutine;

		// Token: 0x0400BCB1 RID: 48305
		[Token(Token = "0x400BCB1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TransOutCoroutine;

		// Token: 0x0400BCB2 RID: 48306
		[Token(Token = "0x400BCB2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CalcCurrentSelectedRoom;

		// Token: 0x0400BCB3 RID: 48307
		[Token(Token = "0x400BCB3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001DDB RID: 7643
		[Token(Token = "0x2001DDB")]
		protected enum PROC
		{
			// Token: 0x0400BCB5 RID: 48309
			[Token(Token = "0x400BCB5")]
			NONE,
			// Token: 0x0400BCB6 RID: 48310
			[Token(Token = "0x400BCB6")]
			TRANS_IN,
			// Token: 0x0400BCB7 RID: 48311
			[Token(Token = "0x400BCB7")]
			IN,
			// Token: 0x0400BCB8 RID: 48312
			[Token(Token = "0x400BCB8")]
			TRANS_OUT,
			// Token: 0x0400BCB9 RID: 48313
			[Token(Token = "0x400BCB9")]
			OUT
		}
	}
}
