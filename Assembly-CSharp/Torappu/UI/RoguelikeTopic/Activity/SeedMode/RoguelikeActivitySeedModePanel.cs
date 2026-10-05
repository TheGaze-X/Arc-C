using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x0200469D RID: 18077
	[Token(Token = "0x200469D")]
	public class RoguelikeActivitySeedModePanel : RoguelikeTopicActivityPanel
	{
		// Token: 0x0601B6DD RID: 112349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6DD")]
		[Address(RVA = "0x14B0810", Offset = "0x14AF410", VA = "0x1814B0810", Slot = "4")]
		protected override void _InitPanel(string topicId, string rlActId)
		{
		}

		// Token: 0x0601B6DE RID: 112350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6DE")]
		[Address(RVA = "0x14B1460", Offset = "0x14B0060", VA = "0x1814B1460", Slot = "5")]
		protected override void _UpdatePanel()
		{
		}

		// Token: 0x0601B6DF RID: 112351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6DF")]
		[Address(RVA = "0x14B05A0", Offset = "0x14AF1A0", VA = "0x1814B05A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B6E0 RID: 112352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6E0")]
		[Address(RVA = "0x14B0D70", Offset = "0x14AF970", VA = "0x1814B0D70")]
		private void _OnClickInputSeed()
		{
		}

		// Token: 0x0601B6E1 RID: 112353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6E1")]
		[Address(RVA = "0x14B08E0", Offset = "0x14AF4E0", VA = "0x1814B08E0")]
		private void _OnClickDisableSeed()
		{
		}

		// Token: 0x0601B6E2 RID: 112354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6E2")]
		[Address(RVA = "0x14B0C10", Offset = "0x14AF810", VA = "0x1814B0C10")]
		private void _OnClickEnableSeedGrade()
		{
		}

		// Token: 0x0601B6E3 RID: 112355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6E3")]
		[Address(RVA = "0x14B11F0", Offset = "0x14AFDF0", VA = "0x1814B11F0")]
		private void _OnClickOpenSelectSeedDialog()
		{
		}

		// Token: 0x0601B6E4 RID: 112356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6E4")]
		[Address(RVA = "0x14B1510", Offset = "0x14B0110", VA = "0x1814B1510")]
		public RoguelikeActivitySeedModePanel()
		{
		}

		// Token: 0x040237B9 RID: 145337
		[Token(Token = "0x40237B9")]
		private const int INPUT_SEED_MAX_CNT = 80;

		// Token: 0x040237BA RID: 145338
		[Token(Token = "0x40237BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040237BB RID: 145339
		[Token(Token = "0x40237BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeActivitySeedModePanelView _view;

		// Token: 0x040237BC RID: 145340
		[Token(Token = "0x40237BC")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeActivitySeedModePanelProperty m_prop;

		// Token: 0x040237BD RID: 145341
		[Token(Token = "0x40237BD")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x040237BE RID: 145342
		[Token(Token = "0x40237BE")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040237BF RID: 145343
		[Token(Token = "0x40237BF")]
		[FieldOffset(Offset = "0x58")]
		private int m_inputSeedDialogInst;

		// Token: 0x040237C0 RID: 145344
		[Token(Token = "0x40237C0")]
		[FieldOffset(Offset = "0x5C")]
		private int m_seedListDialogInst;

		// Token: 0x040237C1 RID: 145345
		[Token(Token = "0x40237C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitPanel;

		// Token: 0x040237C2 RID: 145346
		[Token(Token = "0x40237C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdatePanel;

		// Token: 0x040237C3 RID: 145347
		[Token(Token = "0x40237C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040237C4 RID: 145348
		[Token(Token = "0x40237C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClickInputSeed;

		// Token: 0x040237C5 RID: 145349
		[Token(Token = "0x40237C5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnClickDisableSeed;

		// Token: 0x040237C6 RID: 145350
		[Token(Token = "0x40237C6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClickEnableSeedGrade;

		// Token: 0x040237C7 RID: 145351
		[Token(Token = "0x40237C7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClickOpenSelectSeedDialog;

		// Token: 0x040237C8 RID: 145352
		[Token(Token = "0x40237C8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200469E RID: 18078
		[Token(Token = "0x200469E")]
		public class SetSeedParam
		{
			// Token: 0x0601B6E5 RID: 112357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B6E5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SetSeedParam()
			{
			}

			// Token: 0x040237C9 RID: 145353
			[Token(Token = "0x40237C9")]
			[FieldOffset(Offset = "0x10")]
			public string theme;

			// Token: 0x040237CA RID: 145354
			[Token(Token = "0x40237CA")]
			[FieldOffset(Offset = "0x18")]
			public string activity;

			// Token: 0x040237CB RID: 145355
			[Token(Token = "0x40237CB")]
			[FieldOffset(Offset = "0x20")]
			public string successText;

			// Token: 0x040237CC RID: 145356
			[Token(Token = "0x40237CC")]
			[FieldOffset(Offset = "0x28")]
			public string errorText;
		}

		// Token: 0x0200469F RID: 18079
		[Token(Token = "0x200469F")]
		public class SeedInputDialogConfig : CommonInputDialogServiceConfirmConfig<RoguelikeTopicSetSeedRequest, RoguelikeTopicSetSeedResponse>
		{
			// Token: 0x0601B6E6 RID: 112358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B6E6")]
			[Address(RVA = "0x14D78C0", Offset = "0x14D64C0", VA = "0x1814D78C0", Slot = "7")]
			protected override RoguelikeTopicSetSeedRequest ParseRequest(ValueBundle param, string inputText)
			{
				return null;
			}

			// Token: 0x1700414D RID: 16717
			// (get) Token: 0x0601B6E7 RID: 112359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700414D")]
			protected override string serviceCode
			{
				[Token(Token = "0x601B6E7")]
				[Address(RVA = "0x14D7AB0", Offset = "0x14D66B0", VA = "0x1814D7AB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601B6E8 RID: 112360 RVA: 0x000A52B8 File Offset: 0x000A34B8
			[Token(Token = "0x601B6E8")]
			[Address(RVA = "0x14D7780", Offset = "0x14D6380", VA = "0x1814D7780", Slot = "9")]
			protected override bool OnValidateResponse(ValueBundle param, string inputText, RoguelikeTopicSetSeedResponse response)
			{
				return default(bool);
			}

			// Token: 0x0601B6E9 RID: 112361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B6E9")]
			[Address(RVA = "0x14D7710", Offset = "0x14D6310", VA = "0x1814D7710", Slot = "10")]
			public override string OnInputFieldValueChange(string input)
			{
				return null;
			}

			// Token: 0x0601B6EA RID: 112362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B6EA")]
			[Address(RVA = "0x14D76A0", Offset = "0x14D62A0", VA = "0x1814D76A0", Slot = "11")]
			public override string OnInputFieldEndEdit(string input)
			{
				return null;
			}

			// Token: 0x0601B6EB RID: 112363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B6EB")]
			[Address(RVA = "0x14D7A40", Offset = "0x14D6640", VA = "0x1814D7A40")]
			public SeedInputDialogConfig()
			{
			}

			// Token: 0x040237CD RID: 145357
			[Token(Token = "0x40237CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseRequest;

			// Token: 0x040237CE RID: 145358
			[Token(Token = "0x40237CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x040237CF RID: 145359
			[Token(Token = "0x40237CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnValidateResponse;

			// Token: 0x040237D0 RID: 145360
			[Token(Token = "0x40237D0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnInputFieldValueChange;

			// Token: 0x040237D1 RID: 145361
			[Token(Token = "0x40237D1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnInputFieldEndEdit;

			// Token: 0x040237D2 RID: 145362
			[Token(Token = "0x40237D2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
