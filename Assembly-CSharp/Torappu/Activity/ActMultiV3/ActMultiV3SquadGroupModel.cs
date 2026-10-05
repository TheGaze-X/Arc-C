using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FD0 RID: 28624
	[Token(Token = "0x2006FD0")]
	public class ActMultiV3SquadGroupModel : IHotfixable
	{
		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x06028A60 RID: 166496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A61 RID: 166497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FF3")]
		public string actId
		{
			[Token(Token = "0x6028A60")]
			[Address(RVA = "0x23F5E90", Offset = "0x23F4A90", VA = "0x1823F5E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A61")]
			[Address(RVA = "0x23F6010", Offset = "0x23F4C10", VA = "0x1823F6010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x06028A62 RID: 166498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A63 RID: 166499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FF4")]
		public string selectSquadId
		{
			[Token(Token = "0x6028A62")]
			[Address(RVA = "0x23F5EF0", Offset = "0x23F4AF0", VA = "0x1823F5EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A63")]
			[Address(RVA = "0x23F6090", Offset = "0x23F4C90", VA = "0x1823F6090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x06028A64 RID: 166500 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A65 RID: 166501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FF5")]
		public string squadLockHintStr
		{
			[Token(Token = "0x6028A64")]
			[Address(RVA = "0x23F5FB0", Offset = "0x23F4BB0", VA = "0x1823F5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A65")]
			[Address(RVA = "0x23F6110", Offset = "0x23F4D10", VA = "0x1823F6110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x06028A66 RID: 166502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FF6")]
		public List<ActMultiV3SquadModel> squadList
		{
			[Token(Token = "0x6028A66")]
			[Address(RVA = "0x23F5F50", Offset = "0x23F4B50", VA = "0x1823F5F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028A67 RID: 166503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A67")]
		[Address(RVA = "0x23F5280", Offset = "0x23F3E80", VA = "0x1823F5280")]
		public ActMultiV3SquadModel FindCurrSquadModel()
		{
			return null;
		}

		// Token: 0x06028A68 RID: 166504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A68")]
		[Address(RVA = "0x23F5450", Offset = "0x23F4050", VA = "0x1823F5450")]
		public ActMultiV3SquadModel FindSquadModel(string squadId)
		{
			return null;
		}

		// Token: 0x06028A69 RID: 166505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A69")]
		[Address(RVA = "0x23F5340", Offset = "0x23F3F40", VA = "0x1823F5340")]
		public ActMultiV3SquadModel FindSquadModel(ActMultiV3MapModeType modeType)
		{
			return null;
		}

		// Token: 0x06028A6A RID: 166506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A6A")]
		[Address(RVA = "0x23F5CB0", Offset = "0x23F48B0", VA = "0x1823F5CB0")]
		private ActMultiV3SquadModel _FindSquadModel(string squadId)
		{
			return null;
		}

		// Token: 0x06028A6B RID: 166507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A6B")]
		[Address(RVA = "0x23F54D0", Offset = "0x23F40D0", VA = "0x1823F54D0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028A6C RID: 166508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A6C")]
		[Address(RVA = "0x23F5A90", Offset = "0x23F4690", VA = "0x1823F5A90")]
		private string _FindInitSquadId()
		{
			return null;
		}

		// Token: 0x06028A6D RID: 166509 RVA: 0x000D27F8 File Offset: 0x000D09F8
		[Token(Token = "0x6028A6D")]
		[Address(RVA = "0x23F58A0", Offset = "0x23F44A0", VA = "0x1823F58A0")]
		public bool TrySelectSquad(string squadId)
		{
			return default(bool);
		}

		// Token: 0x06028A6E RID: 166510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A6E")]
		[Address(RVA = "0x23F5DE0", Offset = "0x23F49E0", VA = "0x1823F5DE0")]
		public ActMultiV3SquadGroupModel()
		{
		}

		// Token: 0x04039EA2 RID: 237218
		[Token(Token = "0x4039EA2")]
		[FieldOffset(Offset = "0x10")]
		private List<ActMultiV3SquadModel> m_squadList;

		// Token: 0x04039EA6 RID: 237222
		[Token(Token = "0x4039EA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039EA7 RID: 237223
		[Token(Token = "0x4039EA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039EA8 RID: 237224
		[Token(Token = "0x4039EA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectSquadId;

		// Token: 0x04039EA9 RID: 237225
		[Token(Token = "0x4039EA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectSquadId;

		// Token: 0x04039EAA RID: 237226
		[Token(Token = "0x4039EAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_squadLockHintStr;

		// Token: 0x04039EAB RID: 237227
		[Token(Token = "0x4039EAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_squadLockHintStr;

		// Token: 0x04039EAC RID: 237228
		[Token(Token = "0x4039EAC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_squadList;

		// Token: 0x04039EAD RID: 237229
		[Token(Token = "0x4039EAD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FindCurrSquadModel;

		// Token: 0x04039EAE RID: 237230
		[Token(Token = "0x4039EAE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FindSquadModel;

		// Token: 0x04039EAF RID: 237231
		[Token(Token = "0x4039EAF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_FindSquadModel;

		// Token: 0x04039EB0 RID: 237232
		[Token(Token = "0x4039EB0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FindSquadModel;

		// Token: 0x04039EB1 RID: 237233
		[Token(Token = "0x4039EB1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039EB2 RID: 237234
		[Token(Token = "0x4039EB2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FindInitSquadId;

		// Token: 0x04039EB3 RID: 237235
		[Token(Token = "0x4039EB3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TrySelectSquad;

		// Token: 0x04039EB4 RID: 237236
		[Token(Token = "0x4039EB4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
