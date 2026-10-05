using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E3F RID: 7743
	[Token(Token = "0x2001E3F")]
	public class AVGDisplayableExecutor : ExecutorComponent, IContainsResRefs
	{
		// Token: 0x0600BFB7 RID: 49079 RVA: 0x00046B18 File Offset: 0x00044D18
		[Token(Token = "0x600BFB7")]
		[Address(RVA = "0x33D9170", Offset = "0x33D7D70", VA = "0x1833D9170")]
		private AVGDisplayableExecutor.CmdParam _GenParamWithCmd(Command cmd)
		{
			return default(AVGDisplayableExecutor.CmdParam);
		}

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFB8")]
		[Address(RVA = "0x33D8370", Offset = "0x33D6F70", VA = "0x1833D8370", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600BFB9 RID: 49081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB9")]
		[Address(RVA = "0x33D8500", Offset = "0x33D7100", VA = "0x1833D8500", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600BFBA RID: 49082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBA")]
		[Address(RVA = "0x33D8310", Offset = "0x33D6F10", VA = "0x1833D8310", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600BFBB RID: 49083 RVA: 0x00046B30 File Offset: 0x00044D30
		[Token(Token = "0x600BFBB")]
		[Address(RVA = "0x33D8A40", Offset = "0x33D7640", VA = "0x1833D8A40")]
		private bool _ExecuteAVGDisplayable(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBC")]
		[Address(RVA = "0x33D8760", Offset = "0x33D7360", VA = "0x1833D8760")]
		private void _EnsureManager()
		{
		}

		// Token: 0x0600BFBD RID: 49085 RVA: 0x00046B48 File Offset: 0x00044D48
		[Token(Token = "0x600BFBD")]
		[Address(RVA = "0x33D8EC0", Offset = "0x33D7AC0", VA = "0x1833D8EC0")]
		private bool _ExecuteAnimatedText(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x00046B60 File Offset: 0x00044D60
		[Token(Token = "0x600BFBE")]
		[Address(RVA = "0x33D8C10", Offset = "0x33D7810", VA = "0x1833D8C10")]
		private bool _ExecuteAnimatedTextClean(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBF")]
		[Address(RVA = "0x33D85C0", Offset = "0x33D71C0", VA = "0x1833D85C0")]
		private void _CleanAllTextStamps()
		{
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFC0")]
		[Address(RVA = "0x33D97E0", Offset = "0x33D83E0", VA = "0x1833D97E0")]
		private GameObject _LoadDisplayable(string name, AVGDisplayableType type)
		{
			return null;
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFC1")]
		[Address(RVA = "0x33D8280", Offset = "0x33D6E80", VA = "0x1833D8280", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC2")]
		[Address(RVA = "0x33D9B50", Offset = "0x33D8750", VA = "0x1833D9B50")]
		public AVGDisplayableExecutor()
		{
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC3")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C0EE RID: 49390
		[Token(Token = "0x400C0EE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0400C0EF RID: 49391
		[Token(Token = "0x400C0EF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _bgOverlayTrans;

		// Token: 0x0400C0F0 RID: 49392
		[Token(Token = "0x400C0F0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _charOverlayTrans;

		// Token: 0x0400C0F1 RID: 49393
		[Token(Token = "0x400C0F1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _cgOverlayTrans;

		// Token: 0x0400C0F2 RID: 49394
		[Token(Token = "0x400C0F2")]
		[FieldOffset(Offset = "0x70")]
		private List<AnimatedTextStampView> m_cachedTextStamps;

		// Token: 0x0400C0F3 RID: 49395
		[Token(Token = "0x400C0F3")]
		[FieldOffset(Offset = "0x78")]
		private AVGDisplayableManager m_manager;

		// Token: 0x0400C0F4 RID: 49396
		[Token(Token = "0x400C0F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GenParamWithCmd;

		// Token: 0x0400C0F5 RID: 49397
		[Token(Token = "0x400C0F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C0F6 RID: 49398
		[Token(Token = "0x400C0F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C0F7 RID: 49399
		[Token(Token = "0x400C0F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C0F8 RID: 49400
		[Token(Token = "0x400C0F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteAVGDisplayable;

		// Token: 0x0400C0F9 RID: 49401
		[Token(Token = "0x400C0F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureManager;

		// Token: 0x0400C0FA RID: 49402
		[Token(Token = "0x400C0FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteAnimatedText;

		// Token: 0x0400C0FB RID: 49403
		[Token(Token = "0x400C0FB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteAnimatedTextClean;

		// Token: 0x0400C0FC RID: 49404
		[Token(Token = "0x400C0FC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CleanAllTextStamps;

		// Token: 0x0400C0FD RID: 49405
		[Token(Token = "0x400C0FD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadDisplayable;

		// Token: 0x0400C0FE RID: 49406
		[Token(Token = "0x400C0FE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C0FF RID: 49407
		[Token(Token = "0x400C0FF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E40 RID: 7744
		[Token(Token = "0x2001E40")]
		public struct CmdParam
		{
			// Token: 0x0400C100 RID: 49408
			[Token(Token = "0x400C100")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400C101 RID: 49409
			[Token(Token = "0x400C101")]
			[FieldOffset(Offset = "0x8")]
			public AVGDisplayableType displayableType;

			// Token: 0x0400C102 RID: 49410
			[Token(Token = "0x400C102")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 pos;

			// Token: 0x0400C103 RID: 49411
			[Token(Token = "0x400C103")]
			[FieldOffset(Offset = "0x14")]
			public float duration;

			// Token: 0x0400C104 RID: 49412
			[Token(Token = "0x400C104")]
			[FieldOffset(Offset = "0x18")]
			public bool block;

			// Token: 0x0400C105 RID: 49413
			[Token(Token = "0x400C105")]
			[FieldOffset(Offset = "0x19")]
			public bool clear;

			// Token: 0x0400C106 RID: 49414
			[Token(Token = "0x400C106")]
			[FieldOffset(Offset = "0x20")]
			public string content;

			// Token: 0x0400C107 RID: 49415
			[Token(Token = "0x400C107")]
			[FieldOffset(Offset = "0x28")]
			public string id;

			// Token: 0x0400C108 RID: 49416
			[Token(Token = "0x400C108")]
			[FieldOffset(Offset = "0x30")]
			public string style;
		}

		// Token: 0x02001E41 RID: 7745
		[Token(Token = "0x2001E41")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600BFC4 RID: 49092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BFC4")]
			[Address(RVA = "0x33E9D00", Offset = "0x33E8900", VA = "0x1833E9D00", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600BFC5 RID: 49093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BFC5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InternalResRefCollector()
			{
			}
		}
	}
}
