using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI.Stencil;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003698 RID: 13976
	[Token(Token = "0x2003698")]
	public class CutinChannel : MonoBehaviour, IReusable, IHotfixable
	{
		// Token: 0x060163A2 RID: 91042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A2")]
		[Address(RVA = "0xEAFCE0", Offset = "0xEAE8E0", VA = "0x180EAFCE0")]
		private void _ProcessElement(CutinParam param, Sequence elementSeq, Action cb)
		{
		}

		// Token: 0x060163A3 RID: 91043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163A3")]
		[Address(RVA = "0xEAF8B0", Offset = "0xEAE4B0", VA = "0x180EAF8B0")]
		private CutinElement _GetImgElementByParam(CutinParam param)
		{
			return null;
		}

		// Token: 0x060163A4 RID: 91044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A4")]
		[Address(RVA = "0xEAFC50", Offset = "0xEAE850", VA = "0x180EAFC50")]
		private void _KillCharAnim()
		{
		}

		// Token: 0x060163A5 RID: 91045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A5")]
		[Address(RVA = "0xEAEC60", Offset = "0xEAD860", VA = "0x180EAEC60")]
		public void OnCutinBegin(CutinParam cutin, CutinChannelOptions options, [Optional] Action cb)
		{
		}

		// Token: 0x060163A6 RID: 91046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A6")]
		[Address(RVA = "0xEAF140", Offset = "0xEADD40", VA = "0x180EAF140")]
		public void OnCutinUpdate(CutinParam cutin, Action cb)
		{
		}

		// Token: 0x060163A7 RID: 91047 RVA: 0x000900A8 File Offset: 0x0008E2A8
		[Token(Token = "0x60163A7")]
		[Address(RVA = "0xEB0330", Offset = "0xEAEF30", VA = "0x180EB0330")]
		private bool _TryPlayAnimation(CutinParam param)
		{
			return default(bool);
		}

		// Token: 0x060163A8 RID: 91048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163A8")]
		[Address(RVA = "0xEB0210", Offset = "0xEAEE10", VA = "0x180EB0210")]
		private string _TryGetAnimName(string direction)
		{
			return null;
		}

		// Token: 0x060163A9 RID: 91049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A9")]
		[Address(RVA = "0xEAEFA0", Offset = "0xEADBA0", VA = "0x180EAEFA0")]
		public void OnCutinEnd(CutinParam cutin, Action cb)
		{
		}

		// Token: 0x060163AA RID: 91050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163AA")]
		[Address(RVA = "0xEAEBF0", Offset = "0xEAD7F0", VA = "0x180EAEBF0", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x060163AB RID: 91051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163AB")]
		[Address(RVA = "0xEAF500", Offset = "0xEAE100", VA = "0x180EAF500", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x060163AC RID: 91052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163AC")]
		[Address(RVA = "0xEAF800", Offset = "0xEAE400", VA = "0x180EAF800")]
		private Sequence _EnsureCharSequence()
		{
			return null;
		}

		// Token: 0x060163AD RID: 91053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163AD")]
		[Address(RVA = "0xEAF750", Offset = "0xEAE350", VA = "0x180EAF750")]
		private Sequence _EnsureBgSequence()
		{
			return null;
		}

		// Token: 0x060163AE RID: 91054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163AE")]
		[Address(RVA = "0xEAF640", Offset = "0xEAE240", VA = "0x180EAF640")]
		private Sequence _EnsureAvatarSequence()
		{
			return null;
		}

		// Token: 0x060163AF RID: 91055 RVA: 0x000900C0 File Offset: 0x0008E2C0
		[Token(Token = "0x60163AF")]
		[Address(RVA = "0xEAFB10", Offset = "0xEAE710", VA = "0x180EAFB10")]
		private StencilChannel _GetStencilChannel(int channelIdx)
		{
			return StencilChannel.NONE;
		}

		// Token: 0x060163B0 RID: 91056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163B0")]
		[Address(RVA = "0xEB0610", Offset = "0xEAF210", VA = "0x180EB0610")]
		public CutinChannel()
		{
		}

		// Token: 0x0401AB4E RID: 109390
		[Token(Token = "0x401AB4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CutinImageElement _leftChar;

		// Token: 0x0401AB4F RID: 109391
		[Token(Token = "0x401AB4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CutinImageElement _middleChar;

		// Token: 0x0401AB50 RID: 109392
		[Token(Token = "0x401AB50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CutinImageElement _rightChar;

		// Token: 0x0401AB51 RID: 109393
		[Token(Token = "0x401AB51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CutinImageElement _imgBg;

		// Token: 0x0401AB52 RID: 109394
		[Token(Token = "0x401AB52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _maskContainer;

		// Token: 0x0401AB53 RID: 109395
		[Token(Token = "0x401AB53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _group;

		// Token: 0x0401AB54 RID: 109396
		[Token(Token = "0x401AB54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0401AB55 RID: 109397
		[Token(Token = "0x401AB55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CutinAVGCharacterSlot _slotPrefab;

		// Token: 0x0401AB56 RID: 109398
		[Token(Token = "0x401AB56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _charSlotContainer;

		// Token: 0x0401AB57 RID: 109399
		[Token(Token = "0x401AB57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _decoContainer;

		// Token: 0x0401AB58 RID: 109400
		[Token(Token = "0x401AB58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 _lastBgScale;

		// Token: 0x0401AB59 RID: 109401
		[Token(Token = "0x401AB59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 _lastCharScale;

		// Token: 0x0401AB5A RID: 109402
		[Token(Token = "0x401AB5A")]
		private const string LEFT_SLOT = "left";

		// Token: 0x0401AB5B RID: 109403
		[Token(Token = "0x401AB5B")]
		private const string LEFT_SLOT_SHORT = "l";

		// Token: 0x0401AB5C RID: 109404
		[Token(Token = "0x401AB5C")]
		private const string RIGHT_SLOT = "right";

		// Token: 0x0401AB5D RID: 109405
		[Token(Token = "0x401AB5D")]
		private const string RIGHT_SLOT_SHORT = "r";

		// Token: 0x0401AB5E RID: 109406
		[Token(Token = "0x401AB5E")]
		private const string MIDDLE_SLOT = "middle";

		// Token: 0x0401AB5F RID: 109407
		[Token(Token = "0x401AB5F")]
		private const string MIDDLE_SLOT_SHORT = "m";

		// Token: 0x0401AB60 RID: 109408
		[Token(Token = "0x401AB60")]
		private const string RIGHT_IN_ANIM_NAME = "avg_cutin_hori_right_in_chanel";

		// Token: 0x0401AB61 RID: 109409
		[Token(Token = "0x401AB61")]
		private const string LEFT_IN_ANIM_NAME = "avg_cutin_hori_left_in_chanel";

		// Token: 0x0401AB62 RID: 109410
		[Token(Token = "0x401AB62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly StencilChannel[] stencilChannels;

		// Token: 0x0401AB63 RID: 109411
		[Token(Token = "0x401AB63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Sequence m_charSeq;

		// Token: 0x0401AB64 RID: 109412
		[Token(Token = "0x401AB64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Sequence m_bgSeq;

		// Token: 0x0401AB65 RID: 109413
		[Token(Token = "0x401AB65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Sequence m_avatarSeq;

		// Token: 0x0401AB66 RID: 109414
		[Token(Token = "0x401AB66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CutinTemplate m_maskTemplate;

		// Token: 0x0401AB67 RID: 109415
		[Token(Token = "0x401AB67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0401AB68 RID: 109416
		[Token(Token = "0x401AB68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CutinAVGCharacterSlot m_cachedCharslot;

		// Token: 0x0401AB69 RID: 109417
		[Token(Token = "0x401AB69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int m_channelId;

		// Token: 0x0401AB6A RID: 109418
		[Token(Token = "0x401AB6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ProcessElement;

		// Token: 0x0401AB6B RID: 109419
		[Token(Token = "0x401AB6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetImgElementByParam;

		// Token: 0x0401AB6C RID: 109420
		[Token(Token = "0x401AB6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__KillCharAnim;

		// Token: 0x0401AB6D RID: 109421
		[Token(Token = "0x401AB6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCutinBegin;

		// Token: 0x0401AB6E RID: 109422
		[Token(Token = "0x401AB6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCutinUpdate;

		// Token: 0x0401AB6F RID: 109423
		[Token(Token = "0x401AB6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryPlayAnimation;

		// Token: 0x0401AB70 RID: 109424
		[Token(Token = "0x401AB70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryGetAnimName;

		// Token: 0x0401AB71 RID: 109425
		[Token(Token = "0x401AB71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCutinEnd;

		// Token: 0x0401AB72 RID: 109426
		[Token(Token = "0x401AB72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0401AB73 RID: 109427
		[Token(Token = "0x401AB73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0401AB74 RID: 109428
		[Token(Token = "0x401AB74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EnsureCharSequence;

		// Token: 0x0401AB75 RID: 109429
		[Token(Token = "0x401AB75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnsureBgSequence;

		// Token: 0x0401AB76 RID: 109430
		[Token(Token = "0x401AB76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EnsureAvatarSequence;

		// Token: 0x0401AB77 RID: 109431
		[Token(Token = "0x401AB77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetStencilChannel;

		// Token: 0x0401AB78 RID: 109432
		[Token(Token = "0x401AB78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
