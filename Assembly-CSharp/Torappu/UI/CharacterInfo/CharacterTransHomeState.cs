using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EF4 RID: 24308
	[Token(Token = "0x2005EF4")]
	public class CharacterTransHomeState : State
	{
		// Token: 0x0602338B RID: 144267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602338B")]
		[Address(RVA = "0x1DCDC20", Offset = "0x1DCC820", VA = "0x181DCDC20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602338C RID: 144268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602338C")]
		[Address(RVA = "0x1DCF240", Offset = "0x1DCDE40", VA = "0x181DCF240")]
		private IEnumerator _IntroCoroutine()
		{
			return null;
		}

		// Token: 0x0602338D RID: 144269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602338D")]
		[Address(RVA = "0x1DCF2F0", Offset = "0x1DCDEF0", VA = "0x181DCF2F0")]
		private IEnumerator _OutroCoroutine()
		{
			return null;
		}

		// Token: 0x0602338E RID: 144270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602338E")]
		[Address(RVA = "0x1DCFB20", Offset = "0x1DCE720", VA = "0x181DCFB20")]
		private IEnumerator _ResultDisplayCoroutine(CharUISkinStruct skin, int transIndex)
		{
			return null;
		}

		// Token: 0x0602338F RID: 144271 RVA: 0x000C0240 File Offset: 0x000BE440
		[Token(Token = "0x602338F")]
		[Address(RVA = "0x1DCF090", Offset = "0x1DCDC90", VA = "0x181DCF090")]
		private int _GetCurrentTransIndex(CharacterTransPage.Param param)
		{
			return 0;
		}

		// Token: 0x06023390 RID: 144272 RVA: 0x000C0258 File Offset: 0x000BE458
		[Token(Token = "0x6023390")]
		[Address(RVA = "0x1DCF3A0", Offset = "0x1DCDFA0", VA = "0x181DCF3A0")]
		private CharacterTransHomeState.TrainingParseResult _ParseTrainingInfo(int charInstId)
		{
			return default(CharacterTransHomeState.TrainingParseResult);
		}

		// Token: 0x06023391 RID: 144273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023391")]
		[Address(RVA = "0x1DCE2C0", Offset = "0x1DCCEC0", VA = "0x181DCE2C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023392 RID: 144274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023392")]
		[Address(RVA = "0x1DCEC40", Offset = "0x1DCD840", VA = "0x181DCEC40")]
		private string OnFocusTmpl(int idx)
		{
			return null;
		}

		// Token: 0x06023393 RID: 144275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023393")]
		[Address(RVA = "0x1DCDDB0", Offset = "0x1DCC9B0", VA = "0x181DCDDB0")]
		private void OnClickTmpl(int idx)
		{
		}

		// Token: 0x06023394 RID: 144276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023394")]
		[Address(RVA = "0x1DCE200", Offset = "0x1DCCE00", VA = "0x181DCE200")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023395 RID: 144277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023395")]
		[Address(RVA = "0x1DCDC80", Offset = "0x1DCC880", VA = "0x181DCDC80")]
		public void OnBackButtonPressed()
		{
		}

		// Token: 0x06023396 RID: 144278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023396")]
		[Address(RVA = "0x1DCFC30", Offset = "0x1DCE830", VA = "0x181DCFC30")]
		public CharacterTransHomeState()
		{
		}

		// Token: 0x06023397 RID: 144279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023397")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403087C RID: 198780
		[Token(Token = "0x403087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _viewProto;

		// Token: 0x0403087D RID: 198781
		[Token(Token = "0x403087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _resultViewProto;

		// Token: 0x0403087E RID: 198782
		[Token(Token = "0x403087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x0403087F RID: 198783
		[Token(Token = "0x403087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _blackCover;

		// Token: 0x04030880 RID: 198784
		[Token(Token = "0x4030880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _backButtonPanel;

		// Token: 0x04030881 RID: 198785
		[Token(Token = "0x4030881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CharacterTransView m_transView;

		// Token: 0x04030882 RID: 198786
		[Token(Token = "0x4030882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CharacterTransResultView m_transResultView;

		// Token: 0x04030883 RID: 198787
		[Token(Token = "0x4030883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RenderTexture m_rt;

		// Token: 0x04030884 RID: 198788
		[Token(Token = "0x4030884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine m_resultDisplayCoroutine;

		// Token: 0x04030885 RID: 198789
		[Token(Token = "0x4030885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Coroutine m_introCoroutine;

		// Token: 0x04030886 RID: 198790
		[Token(Token = "0x4030886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Coroutine m_outroCoroutine;

		// Token: 0x04030887 RID: 198791
		[Token(Token = "0x4030887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030888 RID: 198792
		[Token(Token = "0x4030888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IntroCoroutine;

		// Token: 0x04030889 RID: 198793
		[Token(Token = "0x4030889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OutroCoroutine;

		// Token: 0x0403088A RID: 198794
		[Token(Token = "0x403088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResultDisplayCoroutine;

		// Token: 0x0403088B RID: 198795
		[Token(Token = "0x403088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCurrentTransIndex;

		// Token: 0x0403088C RID: 198796
		[Token(Token = "0x403088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ParseTrainingInfo;

		// Token: 0x0403088D RID: 198797
		[Token(Token = "0x403088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403088E RID: 198798
		[Token(Token = "0x403088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnFocusTmpl;

		// Token: 0x0403088F RID: 198799
		[Token(Token = "0x403088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickTmpl;

		// Token: 0x04030890 RID: 198800
		[Token(Token = "0x4030890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04030891 RID: 198801
		[Token(Token = "0x4030891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBackButtonPressed;

		// Token: 0x04030892 RID: 198802
		[Token(Token = "0x4030892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EF5 RID: 24309
		[Token(Token = "0x2005EF5")]
		private struct TrainingParseResult
		{
			// Token: 0x06023398 RID: 144280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023398")]
			[Address(RVA = "0x1DD17E0", Offset = "0x1DD03E0", VA = "0x181DD17E0")]
			public TrainingParseResult(int tl = 0, long tsts = 0L, long tets = 0L, [Optional] List<string> validList)
			{
			}

			// Token: 0x04030893 RID: 198803
			[Token(Token = "0x4030893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int trainingLevel;

			// Token: 0x04030894 RID: 198804
			[Token(Token = "0x4030894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long trainingStartTS;

			// Token: 0x04030895 RID: 198805
			[Token(Token = "0x4030895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long trainingEndTS;

			// Token: 0x04030896 RID: 198806
			[Token(Token = "0x4030896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> validIdList;
		}
	}
}
