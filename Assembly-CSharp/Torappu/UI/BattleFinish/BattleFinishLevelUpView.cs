using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006214 RID: 25108
	[Token(Token = "0x2006214")]
	public class BattleFinishLevelUpView : MonoBehaviour, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x0602439E RID: 148382 RVA: 0x000C3828 File Offset: 0x000C1A28
		// (set) Token: 0x0602439F RID: 148383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005579")]
		public bool onCircleFlag
		{
			[Token(Token = "0x602439E")]
			[Address(RVA = "0x1F17DB0", Offset = "0x1F169B0", VA = "0x181F17DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602439F")]
			[Address(RVA = "0x1F17E70", Offset = "0x1F16A70", VA = "0x181F17E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700557A RID: 21882
		// (get) Token: 0x060243A0 RID: 148384 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060243A1 RID: 148385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700557A")]
		public Action onCloseClicked
		{
			[Token(Token = "0x60243A0")]
			[Address(RVA = "0x1F17E10", Offset = "0x1F16A10", VA = "0x181F17E10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60243A1")]
			[Address(RVA = "0x1F17EE0", Offset = "0x1F16AE0", VA = "0x181F17EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060243A2 RID: 148386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243A2")]
		[Address(RVA = "0x1F17720", Offset = "0x1F16320", VA = "0x181F17720")]
		public void InitLevel(int level, int targetLevel, int exp)
		{
		}

		// Token: 0x060243A3 RID: 148387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60243A3")]
		[Address(RVA = "0x1F175C0", Offset = "0x1F161C0", VA = "0x181F175C0")]
		public IEnumerator Circle()
		{
			return null;
		}

		// Token: 0x060243A4 RID: 148388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243A4")]
		[Address(RVA = "0x1F17670", Offset = "0x1F16270", VA = "0x181F17670")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x060243A5 RID: 148389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243A5")]
		[Address(RVA = "0x1F17AF0", Offset = "0x1F166F0", VA = "0x181F17AF0", Slot = "4")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060243A6 RID: 148390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243A6")]
		[Address(RVA = "0x1F17C70", Offset = "0x1F16870", VA = "0x181F17C70")]
		private void _UpLevel()
		{
		}

		// Token: 0x060243A7 RID: 148391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243A7")]
		[Address(RVA = "0x1F17D50", Offset = "0x1F16950", VA = "0x181F17D50")]
		public BattleFinishLevelUpView()
		{
		}

		// Token: 0x040325ED RID: 206317
		[Token(Token = "0x40325ED")]
		private const float MIN_ROUND_ANGLE = 0.3f;

		// Token: 0x040325EE RID: 206318
		[Token(Token = "0x40325EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x040325EF RID: 206319
		[Token(Token = "0x40325EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _lvl;

		// Token: 0x040325F0 RID: 206320
		[Token(Token = "0x40325F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _lvlUpText;

		// Token: 0x040325F1 RID: 206321
		[Token(Token = "0x40325F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _lvlRecoverText;

		// Token: 0x040325F2 RID: 206322
		[Token(Token = "0x40325F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lvlUpObj;

		// Token: 0x040325F3 RID: 206323
		[Token(Token = "0x40325F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MeshRenderer _circleYellow;

		// Token: 0x040325F4 RID: 206324
		[Token(Token = "0x40325F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MeshRenderer _cirlceLight;

		// Token: 0x040325F5 RID: 206325
		[Token(Token = "0x40325F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelLvlUp;

		// Token: 0x040325F7 RID: 206327
		[Token(Token = "0x40325F7")]
		[FieldOffset(Offset = "0x5C")]
		private int m_level;

		// Token: 0x040325F8 RID: 206328
		[Token(Token = "0x40325F8")]
		[FieldOffset(Offset = "0x60")]
		private int m_targetLevel;

		// Token: 0x040325F9 RID: 206329
		[Token(Token = "0x40325F9")]
		[FieldOffset(Offset = "0x64")]
		private float m_percent;

		// Token: 0x040325FB RID: 206331
		[Token(Token = "0x40325FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCircleFlag;

		// Token: 0x040325FC RID: 206332
		[Token(Token = "0x40325FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCircleFlag;

		// Token: 0x040325FD RID: 206333
		[Token(Token = "0x40325FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCloseClicked;

		// Token: 0x040325FE RID: 206334
		[Token(Token = "0x40325FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCloseClicked;

		// Token: 0x040325FF RID: 206335
		[Token(Token = "0x40325FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitLevel;

		// Token: 0x04032600 RID: 206336
		[Token(Token = "0x4032600")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Circle;

		// Token: 0x04032601 RID: 206337
		[Token(Token = "0x4032601")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x04032602 RID: 206338
		[Token(Token = "0x4032602")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04032603 RID: 206339
		[Token(Token = "0x4032603")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpLevel;

		// Token: 0x04032604 RID: 206340
		[Token(Token = "0x4032604")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
