using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E94 RID: 7828
	[Token(Token = "0x2001E94")]
	public class AVGCharacterCutinPanel : ExecutorComponent, IContainsResRefs
	{
		// Token: 0x0600C1CF RID: 49615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1CF")]
		[Address(RVA = "0x33EE660", Offset = "0x33ED260", VA = "0x1833EE660", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C1D0 RID: 49616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D0")]
		[Address(RVA = "0x33EE7F0", Offset = "0x33ED3F0", VA = "0x1833EE7F0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1D1")]
		[Address(RVA = "0x33EE570", Offset = "0x33ED170", VA = "0x1833EE570", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x00047268 File Offset: 0x00045468
		[Token(Token = "0x600C1D2")]
		[Address(RVA = "0x33EE9A0", Offset = "0x33ED5A0", VA = "0x1833EE9A0")]
		private bool _ExecuteCharacterCutin(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1D3 RID: 49619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D3")]
		[Address(RVA = "0x33F03D0", Offset = "0x33EEFD0", VA = "0x1833F03D0")]
		private void _Reset()
		{
		}

		// Token: 0x0600C1D4 RID: 49620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D4")]
		[Address(RVA = "0x33EE600", Offset = "0x33ED200", VA = "0x1833EE600", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x00047280 File Offset: 0x00045480
		[Token(Token = "0x600C1D5")]
		[Address(RVA = "0x33EEF40", Offset = "0x33EDB40", VA = "0x1833EEF40")]
		private bool _ExecuteInterlude(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D6")]
		[Address(RVA = "0x33EFF20", Offset = "0x33EEB20", VA = "0x1833EFF20")]
		private void _InitCutinIfNot()
		{
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1D7")]
		[Address(RVA = "0x33EF1D0", Offset = "0x33EDDD0", VA = "0x1833EF1D0")]
		private CutinParam _GenCutinParamWithCommand(Command command)
		{
			return null;
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x00047298 File Offset: 0x00045498
		[Token(Token = "0x600C1D8")]
		[Address(RVA = "0x33F0230", Offset = "0x33EEE30", VA = "0x1833F0230")]
		private Vector2 _ParseVector(string rawVector)
		{
			return default(Vector2);
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x000472B0 File Offset: 0x000454B0
		[Token(Token = "0x600C1D9")]
		[Address(RVA = "0x33EFD90", Offset = "0x33EE990", VA = "0x1833EFD90")]
		private CutinParam.ParamType _GenCutinType(string param)
		{
			return CutinParam.ParamType.NONE;
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1DA")]
		[Address(RVA = "0x33EFEC0", Offset = "0x33EEAC0", VA = "0x1833EFEC0")]
		private static string _GetMaskPathFromId(string maskId)
		{
			return null;
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1DB")]
		[Address(RVA = "0x33F0540", Offset = "0x33EF140", VA = "0x1833F0540")]
		public AVGCharacterCutinPanel()
		{
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1DD")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C35B RID: 50011
		[Token(Token = "0x400C35B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObjectPoolComponent _slotPool;

		// Token: 0x0400C35C RID: 50012
		[Token(Token = "0x400C35C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _cutinContainer;

		// Token: 0x0400C35D RID: 50013
		[Token(Token = "0x400C35D")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, AVGCharacterCutinSlot> _slots;

		// Token: 0x0400C35E RID: 50014
		[Token(Token = "0x400C35E")]
		[FieldOffset(Offset = "0x68")]
		private CutinController m_cutinController;

		// Token: 0x0400C35F RID: 50015
		[Token(Token = "0x400C35F")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Inited;

		// Token: 0x0400C360 RID: 50016
		[Token(Token = "0x400C360")]
		private const string CUTIN_ELEMENT_TYPE_CHAR = "uichar";

		// Token: 0x0400C361 RID: 50017
		[Token(Token = "0x400C361")]
		private const string CUTIN_ELEMENT_TYPE_BG = "bg";

		// Token: 0x0400C362 RID: 50018
		[Token(Token = "0x400C362")]
		private const string CUTIN_ELEMENT_TYPE_CHARACTER = "char";

		// Token: 0x0400C363 RID: 50019
		[Token(Token = "0x400C363")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C364 RID: 50020
		[Token(Token = "0x400C364")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C365 RID: 50021
		[Token(Token = "0x400C365")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C366 RID: 50022
		[Token(Token = "0x400C366")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterCutin;

		// Token: 0x0400C367 RID: 50023
		[Token(Token = "0x400C367")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0400C368 RID: 50024
		[Token(Token = "0x400C368")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C369 RID: 50025
		[Token(Token = "0x400C369")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteInterlude;

		// Token: 0x0400C36A RID: 50026
		[Token(Token = "0x400C36A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitCutinIfNot;

		// Token: 0x0400C36B RID: 50027
		[Token(Token = "0x400C36B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenCutinParamWithCommand;

		// Token: 0x0400C36C RID: 50028
		[Token(Token = "0x400C36C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ParseVector;

		// Token: 0x0400C36D RID: 50029
		[Token(Token = "0x400C36D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenCutinType;

		// Token: 0x0400C36E RID: 50030
		[Token(Token = "0x400C36E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetMaskPathFromId;

		// Token: 0x0400C36F RID: 50031
		[Token(Token = "0x400C36F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E95 RID: 7829
		[Token(Token = "0x2001E95")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C1DE RID: 49630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1DE")]
			[Address(RVA = "0x34046D0", Offset = "0x34032D0", VA = "0x1834046D0", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C1DF RID: 49631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1DF")]
			[Address(RVA = "0x34043E0", Offset = "0x3402FE0", VA = "0x1834043E0", Slot = "5")]
			public override void GatherResFilenames(Command command, HashSet<string> filenames)
			{
			}

			// Token: 0x0600C1E0 RID: 49632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C1E0")]
			[Address(RVA = "0x3404C30", Offset = "0x3403830", VA = "0x183404C30")]
			private string _StripResPath(string name)
			{
				return null;
			}

			// Token: 0x0600C1E1 RID: 49633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C1E1")]
			[Address(RVA = "0x3404D60", Offset = "0x3403960", VA = "0x183404D60")]
			public InternalResRefCollector()
			{
			}

			// Token: 0x0400C370 RID: 50032
			[Token(Token = "0x400C370")]
			[FieldOffset(Offset = "0x10")]
			private Regex m_regex;
		}
	}
}
