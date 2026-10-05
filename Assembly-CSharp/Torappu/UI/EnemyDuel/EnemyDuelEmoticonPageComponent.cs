using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FE2 RID: 20450
	[Token(Token = "0x2004FE2")]
	public class EnemyDuelEmoticonPageComponent : PageSingleComponent, IValueMsgReceiver
	{
		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x0601E5C0 RID: 124352 RVA: 0x000AE450 File Offset: 0x000AC650
		// (set) Token: 0x0601E5C1 RID: 124353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046F7")]
		public bool isEmoticonDisabled
		{
			[Token(Token = "0x601E5C0")]
			[Address(RVA = "0x18194E0", Offset = "0x18180E0", VA = "0x1818194E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E5C1")]
			[Address(RVA = "0x1819540", Offset = "0x1818140", VA = "0x181819540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E5C2 RID: 124354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C2")]
		[Address(RVA = "0x1818A70", Offset = "0x1817670", VA = "0x181818A70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601E5C3 RID: 124355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C3")]
		[Address(RVA = "0x1818D00", Offset = "0x1817900", VA = "0x181818D00", Slot = "12")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E5C4 RID: 124356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C4")]
		[Address(RVA = "0x1818F90", Offset = "0x1817B90", VA = "0x181818F90")]
		private void _OnBtnEmoticonClicked()
		{
		}

		// Token: 0x0601E5C5 RID: 124357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C5")]
		[Address(RVA = "0x18190A0", Offset = "0x1817CA0", VA = "0x1818190A0")]
		private void _OnReceiveEmojiMsg(object arg)
		{
		}

		// Token: 0x0601E5C6 RID: 124358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C6")]
		[Address(RVA = "0x18193C0", Offset = "0x1817FC0", VA = "0x1818193C0")]
		private void _ShowEmoticonItem(EnemyDuelEmojiData param)
		{
		}

		// Token: 0x0601E5C7 RID: 124359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C7")]
		[Address(RVA = "0x1819480", Offset = "0x1818080", VA = "0x181819480")]
		public EnemyDuelEmoticonPageComponent()
		{
		}

		// Token: 0x0601E5C9 RID: 124361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5C9")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0402898C RID: 166284
		[Token(Token = "0x402898C")]
		[NonSerialized]
		public const int MSG_BTN_EMOTICON_CLICKED = 0;

		// Token: 0x0402898D RID: 166285
		[Token(Token = "0x402898D")]
		[NonSerialized]
		public const int MSG_HIDE_EMOTICON_PANEL = 1;

		// Token: 0x0402898E RID: 166286
		[Token(Token = "0x402898E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyDuelEmoticonController _controller;

		// Token: 0x0402898F RID: 166287
		[Token(Token = "0x402898F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04028990 RID: 166288
		[Token(Token = "0x4028990")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("EmoticonBarrage")]
		private AnimationCurve _barrageWeightCurve;

		// Token: 0x04028991 RID: 166289
		[Token(Token = "0x4028991")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("EmoticonBarrage")]
		private int _barrageLaneCount;

		// Token: 0x04028992 RID: 166290
		[Token(Token = "0x4028992")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("EmoticonBarrage")]
		private long _maxBarrageInterval;

		// Token: 0x04028993 RID: 166291
		[Token(Token = "0x4028993")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("EmoticonBarrage")]
		private RectTransform _barrageContainer;

		// Token: 0x04028994 RID: 166292
		[Token(Token = "0x4028994")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("EmoticonBarrage")]
		private EnemyDuelEmoticonBarrageItem _prefabBarrageItem;

		// Token: 0x04028995 RID: 166293
		[Token(Token = "0x4028995")]
		[FieldOffset(Offset = "0x58")]
		private EnemyDuelEmoticonPageComponent.BarrageManager m_barrageManager;

		// Token: 0x04028996 RID: 166294
		[Token(Token = "0x4028996")]
		[FieldOffset(Offset = "0x60")]
		private GameObjectPool m_barragePool;

		// Token: 0x04028998 RID: 166296
		[Token(Token = "0x4028998")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmoticonDisabled;

		// Token: 0x04028999 RID: 166297
		[Token(Token = "0x4028999")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isEmoticonDisabled;

		// Token: 0x0402899A RID: 166298
		[Token(Token = "0x402899A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402899B RID: 166299
		[Token(Token = "0x402899B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402899C RID: 166300
		[Token(Token = "0x402899C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBtnEmoticonClicked;

		// Token: 0x0402899D RID: 166301
		[Token(Token = "0x402899D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnReceiveEmojiMsg;

		// Token: 0x0402899E RID: 166302
		[Token(Token = "0x402899E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowEmoticonItem;

		// Token: 0x0402899F RID: 166303
		[Token(Token = "0x402899F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FE3 RID: 20451
		[Token(Token = "0x2004FE3")]
		private class BarrageLane : IItemWithWeight
		{
			// Token: 0x170046F8 RID: 18168
			// (get) Token: 0x0601E5CA RID: 124362 RVA: 0x000AE468 File Offset: 0x000AC668
			// (set) Token: 0x0601E5CB RID: 124363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170046F8")]
			public float weightValue
			{
				[Token(Token = "0x601E5CA")]
				[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x601E5CB")]
				[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601E5CC RID: 124364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BarrageLane()
			{
			}

			// Token: 0x040289A0 RID: 166304
			[Token(Token = "0x40289A0")]
			[FieldOffset(Offset = "0x10")]
			public float samplePos;

			// Token: 0x040289A1 RID: 166305
			[Token(Token = "0x40289A1")]
			[FieldOffset(Offset = "0x18")]
			public long lastBarrageTs;
		}

		// Token: 0x02004FE4 RID: 20452
		[Token(Token = "0x2004FE4")]
		private class BarrageManager : IHotfixable
		{
			// Token: 0x0601E5CD RID: 124365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5CD")]
			[Address(RVA = "0x180E5D0", Offset = "0x180D1D0", VA = "0x18180E5D0")]
			public BarrageManager(EnemyDuelEmoticonPageComponent closure)
			{
			}

			// Token: 0x0601E5CE RID: 124366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5CE")]
			[Address(RVA = "0x180DB50", Offset = "0x180C750", VA = "0x18180DB50")]
			public void AddBarrage(EnemyDuelEmoticonBarrageItem.EmoticonBarrageItemParam param)
			{
			}

			// Token: 0x0601E5CF RID: 124367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E5CF")]
			[Address(RVA = "0x180E1B0", Offset = "0x180CDB0", VA = "0x18180E1B0")]
			private EnemyDuelEmoticonPageComponent.BarrageLane _ChooseBarrageLane()
			{
				return null;
			}

			// Token: 0x0601E5D0 RID: 124368 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E5D0")]
			[Address(RVA = "0x180E000", Offset = "0x180CC00", VA = "0x18180E000")]
			private EnemyDuelEmoticonBarrageItem _AllocateBarrageItem()
			{
				return null;
			}

			// Token: 0x0601E5D1 RID: 124369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5D1")]
			[Address(RVA = "0x180E500", Offset = "0x180D100", VA = "0x18180E500")]
			private void _RecycleBarrageItem(EnemyDuelEmoticonBarrageItem item)
			{
			}

			// Token: 0x0601E5D2 RID: 124370 RVA: 0x000AE480 File Offset: 0x000AC680
			[Token(Token = "0x601E5D2")]
			[Address(RVA = "0x180E440", Offset = "0x180D040", VA = "0x18180E440")]
			private float _GetLaneSamplePos(int index, int count)
			{
				return 0f;
			}

			// Token: 0x040289A3 RID: 166307
			[Token(Token = "0x40289A3")]
			[FieldOffset(Offset = "0x10")]
			private EnemyDuelEmoticonPageComponent m_closure;

			// Token: 0x040289A4 RID: 166308
			[Token(Token = "0x40289A4")]
			[FieldOffset(Offset = "0x18")]
			private EnemyDuelEmoticonPageComponent.BarrageLane[] m_barrageLanes;

			// Token: 0x040289A5 RID: 166309
			[Token(Token = "0x40289A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040289A6 RID: 166310
			[Token(Token = "0x40289A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_AddBarrage;

			// Token: 0x040289A7 RID: 166311
			[Token(Token = "0x40289A7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__ChooseBarrageLane;

			// Token: 0x040289A8 RID: 166312
			[Token(Token = "0x40289A8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__AllocateBarrageItem;

			// Token: 0x040289A9 RID: 166313
			[Token(Token = "0x40289A9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RecycleBarrageItem;

			// Token: 0x040289AA RID: 166314
			[Token(Token = "0x40289AA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GetLaneSamplePos;
		}
	}
}
