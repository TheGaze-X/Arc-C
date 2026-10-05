using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200369F RID: 13983
	[Token(Token = "0x200369F")]
	public class CutinController : MonoBehaviour, IHotfixable
	{
		// Token: 0x060163B6 RID: 91062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163B6")]
		[Address(RVA = "0xEB0860", Offset = "0xEAF460", VA = "0x180EB0860")]
		public void InitCutin(CutinController.Options initOptions)
		{
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x060163B7 RID: 91063 RVA: 0x000900D8 File Offset: 0x0008E2D8
		[Token(Token = "0x1700356C")]
		public bool isRunning
		{
			[Token(Token = "0x60163B7")]
			[Address(RVA = "0xEB1760", Offset = "0xEB0360", VA = "0x180EB1760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060163B8 RID: 91064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163B8")]
		[Address(RVA = "0xEB0AD0", Offset = "0xEAF6D0", VA = "0x180EB0AD0")]
		public void RunCutin(CutinParam param, [Optional] Action onCutinEnd)
		{
		}

		// Token: 0x060163B9 RID: 91065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163B9")]
		[Address(RVA = "0xEB0E80", Offset = "0xEAFA80", VA = "0x180EB0E80")]
		private void _ProcessChannelClean(CutinParam param, [Optional] Action onCutinEnd)
		{
		}

		// Token: 0x060163BA RID: 91066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163BA")]
		[Address(RVA = "0xEB1220", Offset = "0xEAFE20", VA = "0x180EB1220")]
		private void _ProcessChannel(CutinParam param, [Optional] Action onCutinEnd)
		{
		}

		// Token: 0x060163BB RID: 91067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163BB")]
		[Address(RVA = "0xEB0C80", Offset = "0xEAF880", VA = "0x180EB0C80")]
		public void StopCutin(string errorMsg, bool isInterrupt = false)
		{
		}

		// Token: 0x060163BC RID: 91068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163BC")]
		[Address(RVA = "0xEB0700", Offset = "0xEAF300", VA = "0x180EB0700")]
		public void EndCutin(string errorMsg, bool isInterrupt = false)
		{
		}

		// Token: 0x060163BD RID: 91069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163BD")]
		[Address(RVA = "0xEB0900", Offset = "0xEAF500", VA = "0x180EB0900")]
		public void Reset()
		{
		}

		// Token: 0x060163BE RID: 91070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163BE")]
		[Address(RVA = "0xEB16B0", Offset = "0xEB02B0", VA = "0x180EB16B0")]
		public CutinController()
		{
		}

		// Token: 0x0401ABA8 RID: 109480
		[Token(Token = "0x401ABA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObjectPoolComponent _channelPool;

		// Token: 0x0401ABA9 RID: 109481
		[Token(Token = "0x401ABA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0401ABAA RID: 109482
		[Token(Token = "0x401ABAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CutinController.Options m_initOptions;

		// Token: 0x0401ABAB RID: 109483
		[Token(Token = "0x401ABAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, CutinChannel> _cutinChannels;

		// Token: 0x0401ABAC RID: 109484
		[Token(Token = "0x401ABAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CutinParam m_cutin;

		// Token: 0x0401ABAD RID: 109485
		[Token(Token = "0x401ABAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsInited;

		// Token: 0x0401ABAE RID: 109486
		[Token(Token = "0x401ABAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitCutin;

		// Token: 0x0401ABAF RID: 109487
		[Token(Token = "0x401ABAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRunning;

		// Token: 0x0401ABB0 RID: 109488
		[Token(Token = "0x401ABB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RunCutin;

		// Token: 0x0401ABB1 RID: 109489
		[Token(Token = "0x401ABB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ProcessChannelClean;

		// Token: 0x0401ABB2 RID: 109490
		[Token(Token = "0x401ABB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ProcessChannel;

		// Token: 0x0401ABB3 RID: 109491
		[Token(Token = "0x401ABB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StopCutin;

		// Token: 0x0401ABB4 RID: 109492
		[Token(Token = "0x401ABB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EndCutin;

		// Token: 0x0401ABB5 RID: 109493
		[Token(Token = "0x401ABB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401ABB6 RID: 109494
		[Token(Token = "0x401ABB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020036A0 RID: 13984
		[Token(Token = "0x20036A0")]
		public struct Options
		{
			// Token: 0x0401ABB7 RID: 109495
			[Token(Token = "0x401ABB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ILoadAsset assetLoader;

			// Token: 0x0401ABB8 RID: 109496
			[Token(Token = "0x401ABB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Func<string, string> getMaskPathFromId;
		}
	}
}
