using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x02001897 RID: 6295
	[Token(Token = "0x2001897")]
	public class FurnitureEntity : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06009F34 RID: 40756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001204")]
		public DIYRoom.IFurnitureController controller
		{
			[Token(Token = "0x6009F34")]
			[Address(RVA = "0x319B6B0", Offset = "0x319A2B0", VA = "0x18319B6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06009F35 RID: 40757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001205")]
		public Dictionary<SharedConsts.Direction, FurnitureEntity.FourDirLocalOffset> fourDirLocalOffsetDict
		{
			[Token(Token = "0x6009F35")]
			[Address(RVA = "0x319B8B0", Offset = "0x319A4B0", VA = "0x18319B8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F36")]
		[Address(RVA = "0x3199690", Offset = "0x3198290", VA = "0x183199690")]
		public void RegisterControllerHolder([Optional] DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F37")]
		[Address(RVA = "0x319AF90", Offset = "0x3199B90", VA = "0x18319AF90")]
		private void _Reset()
		{
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F38")]
		[Address(RVA = "0x3199380", Offset = "0x3197F80", VA = "0x183199380")]
		public void PlayDragedAnim()
		{
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F39")]
		[Address(RVA = "0x3199060", Offset = "0x3197C60", VA = "0x183199060")]
		public void PlayDragedAnim(Transform trans)
		{
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F3A")]
		[Address(RVA = "0x3199A70", Offset = "0x3198670", VA = "0x183199A70")]
		public void StopDragedAnim()
		{
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F3B")]
		[Address(RVA = "0x3198FF0", Offset = "0x3197BF0", VA = "0x183198FF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F3C")]
		[Address(RVA = "0x3198D80", Offset = "0x3197980", VA = "0x183198D80")]
		public FurnitureEntity.AttachPoint[] GatherAttachPoints()
		{
			return null;
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06009F3D RID: 40765 RVA: 0x0003E208 File Offset: 0x0003C408
		// (set) Token: 0x06009F3E RID: 40766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001206")]
		public SharedConsts.Direction direction
		{
			[Token(Token = "0x6009F3D")]
			[Address(RVA = "0x319B710", Offset = "0x319A310", VA = "0x18319B710")]
			get
			{
				return SharedConsts.Direction.UP;
			}
			[Token(Token = "0x6009F3E")]
			[Address(RVA = "0x319BB30", Offset = "0x319A730", VA = "0x18319BB30")]
			set
			{
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x0003E220 File Offset: 0x0003C420
		[Token(Token = "0x17001207")]
		public bool isDefaultDir
		{
			[Token(Token = "0x6009F3F")]
			[Address(RVA = "0x319BAD0", Offset = "0x319A6D0", VA = "0x18319BAD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06009F40 RID: 40768 RVA: 0x0003E238 File Offset: 0x0003C438
		[Token(Token = "0x17001208")]
		public bool enableInteract
		{
			[Token(Token = "0x6009F40")]
			[Address(RVA = "0x319B770", Offset = "0x319A370", VA = "0x18319B770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x0003E250 File Offset: 0x0003C450
		[Token(Token = "0x17001209")]
		public bool enableRotate
		{
			[Token(Token = "0x6009F41")]
			[Address(RVA = "0x319B830", Offset = "0x319A430", VA = "0x18319B830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F42")]
		[Address(RVA = "0x3199900", Offset = "0x3198500", VA = "0x183199900")]
		public void RotateToNext(out Vector2 posOffset, int maxLRWidth = 10)
		{
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x0003E268 File Offset: 0x0003C468
		[Token(Token = "0x6009F43")]
		[Address(RVA = "0x319ACC0", Offset = "0x31998C0", VA = "0x18319ACC0")]
		private FurnitureEntity.FourDirLocalOffset _GetRotateInitInfo(Transform trans)
		{
			return default(FurnitureEntity.FourDirLocalOffset);
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F44")]
		[Address(RVA = "0x3199B10", Offset = "0x3198710", VA = "0x183199B10")]
		public void UpdateRotateState()
		{
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F45")]
		[Address(RVA = "0x319AFF0", Offset = "0x3199BF0", VA = "0x18319AFF0")]
		private void _UpdateRotateState(Transform trans)
		{
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F46")]
		[Address(RVA = "0x319B570", Offset = "0x319A170", VA = "0x18319B570")]
		public FurnitureEntity()
		{
		}

		// Token: 0x040095D7 RID: 38359
		[Token(Token = "0x40095D7")]
		private const string FURNITURE_MODEL_PREFIX = "S_";

		// Token: 0x040095D8 RID: 38360
		[Token(Token = "0x40095D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FurnitureEntity.AttachPoint[] attachPoints;

		// Token: 0x040095D9 RID: 38361
		[Token(Token = "0x40095D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SharedConsts.Direction m_direction;

		// Token: 0x040095DA RID: 38362
		[Token(Token = "0x40095DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_oldDim;

		// Token: 0x040095DB RID: 38363
		[Token(Token = "0x40095DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DIYRoom.IFurnitureController m_controller;

		// Token: 0x040095DC RID: 38364
		[Token(Token = "0x40095DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, FurnitureEntity.FourDirLocalOffset> m_InitFourDirInfo;

		// Token: 0x040095DD RID: 38365
		[Token(Token = "0x40095DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Tween m_DragedTween;

		// Token: 0x040095DE RID: 38366
		[Token(Token = "0x40095DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_validOnRotate;

		// Token: 0x040095DF RID: 38367
		[Token(Token = "0x40095DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_isOnCeil;

		// Token: 0x040095E0 RID: 38368
		[Token(Token = "0x40095E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool m_isOnWall;

		// Token: 0x040095E1 RID: 38369
		[Token(Token = "0x40095E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public List<FurnitureEntity.FourDirLocalOffset> _fourDirLocalOffset;

		// Token: 0x040095E2 RID: 38370
		[Token(Token = "0x40095E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040095E3 RID: 38371
		[Token(Token = "0x40095E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fourDirLocalOffsetDict;

		// Token: 0x040095E4 RID: 38372
		[Token(Token = "0x40095E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterControllerHolder;

		// Token: 0x040095E5 RID: 38373
		[Token(Token = "0x40095E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x040095E6 RID: 38374
		[Token(Token = "0x40095E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayDragedAnim;

		// Token: 0x040095E7 RID: 38375
		[Token(Token = "0x40095E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_PlayDragedAnim;

		// Token: 0x040095E8 RID: 38376
		[Token(Token = "0x40095E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopDragedAnim;

		// Token: 0x040095E9 RID: 38377
		[Token(Token = "0x40095E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040095EA RID: 38378
		[Token(Token = "0x40095EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherAttachPoints;

		// Token: 0x040095EB RID: 38379
		[Token(Token = "0x40095EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_direction;

		// Token: 0x040095EC RID: 38380
		[Token(Token = "0x40095EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_direction;

		// Token: 0x040095ED RID: 38381
		[Token(Token = "0x40095ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isDefaultDir;

		// Token: 0x040095EE RID: 38382
		[Token(Token = "0x40095EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_enableInteract;

		// Token: 0x040095EF RID: 38383
		[Token(Token = "0x40095EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_enableRotate;

		// Token: 0x040095F0 RID: 38384
		[Token(Token = "0x40095F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RotateToNext;

		// Token: 0x040095F1 RID: 38385
		[Token(Token = "0x40095F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetRotateInitInfo;

		// Token: 0x040095F2 RID: 38386
		[Token(Token = "0x40095F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateRotateState;

		// Token: 0x040095F3 RID: 38387
		[Token(Token = "0x40095F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateRotateState;

		// Token: 0x040095F4 RID: 38388
		[Token(Token = "0x40095F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001898 RID: 6296
		[Token(Token = "0x2001898")]
		[Serializable]
		public class IntPair
		{
			// Token: 0x06009F48 RID: 40776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F48")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IntPair()
			{
			}

			// Token: 0x040095F5 RID: 38389
			[Token(Token = "0x40095F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x040095F6 RID: 38390
			[Token(Token = "0x40095F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int y;
		}

		// Token: 0x02001899 RID: 6297
		[Token(Token = "0x2001899")]
		[Serializable]
		public class AttachPoint : DIYRoom.IAttachPoint
		{
			// Token: 0x1700120A RID: 4618
			// (get) Token: 0x06009F49 RID: 40777 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700120A")]
			public Transform targetPoint
			{
				[Token(Token = "0x6009F49")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700120B RID: 4619
			// (get) Token: 0x06009F4A RID: 40778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700120B")]
			public string animationKey
			{
				[Token(Token = "0x6009F4A")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700120C RID: 4620
			// (get) Token: 0x06009F4B RID: 40779 RVA: 0x0003E298 File Offset: 0x0003C498
			// (set) Token: 0x06009F4C RID: 40780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700120C")]
			public SharedConsts.LeftOrRight leftOrRight
			{
				[Token(Token = "0x6009F4B")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "6")]
				get
				{
					return SharedConsts.LeftOrRight.LEFT;
				}
				[Token(Token = "0x6009F4C")]
				[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
				set
				{
				}
			}

			// Token: 0x1700120D RID: 4621
			// (get) Token: 0x06009F4D RID: 40781 RVA: 0x0003E2B0 File Offset: 0x0003C4B0
			[Token(Token = "0x1700120D")]
			public bool specifyDir
			{
				[Token(Token = "0x6009F4D")]
				[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700120E RID: 4622
			// (get) Token: 0x06009F4E RID: 40782 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
			[Token(Token = "0x1700120E")]
			public Vector2 interactTime
			{
				[Token(Token = "0x6009F4E")]
				[Address(RVA = "0x318C4E0", Offset = "0x318B0E0", VA = "0x18318C4E0", Slot = "8")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x06009F4F RID: 40783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F4F")]
			[Address(RVA = "0x318C2B0", Offset = "0x318AEB0", VA = "0x18318C2B0", Slot = "9")]
			public void QueryEntryPoints(Action<int, int> action)
			{
			}

			// Token: 0x06009F50 RID: 40784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F50")]
			[Address(RVA = "0x318C360", Offset = "0x318AF60", VA = "0x18318C360")]
			public void SetEntryPoints(Func<int, int, Vector2> action)
			{
			}

			// Token: 0x1700120F RID: 4623
			// (get) Token: 0x06009F51 RID: 40785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700120F")]
			public string interactId
			{
				[Token(Token = "0x6009F51")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009F52 RID: 40786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F52")]
			[Address(RVA = "0x318C470", Offset = "0x318B070", VA = "0x18318C470")]
			public AttachPoint()
			{
			}

			// Token: 0x040095F7 RID: 38391
			[Token(Token = "0x40095F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _targetPoint;

			// Token: 0x040095F8 RID: 38392
			[Token(Token = "0x40095F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _animationKey;

			// Token: 0x040095F9 RID: 38393
			[Token(Token = "0x40095F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private SharedConsts.LeftOrRight _leftOrRight;

			// Token: 0x040095FA RID: 38394
			[Token(Token = "0x40095FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			private bool _specifyDir;

			// Token: 0x040095FB RID: 38395
			[Token(Token = "0x40095FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Vector2 _interactTime;

			// Token: 0x040095FC RID: 38396
			[Token(Token = "0x40095FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private string _interactId;

			// Token: 0x040095FD RID: 38397
			[Token(Token = "0x40095FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			private FurnitureEntity.IntPair[] _entries;
		}

		// Token: 0x0200189A RID: 6298
		[Token(Token = "0x200189A")]
		[Serializable]
		public struct FourDirLocalOffset
		{
			// Token: 0x040095FE RID: 38398
			[Token(Token = "0x40095FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SharedConsts.Direction direction;

			// Token: 0x040095FF RID: 38399
			[Token(Token = "0x40095FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 position;

			// Token: 0x04009600 RID: 38400
			[Token(Token = "0x4009600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 rotation;

			// Token: 0x04009601 RID: 38401
			[Token(Token = "0x4009601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 scale;
		}
	}
}
