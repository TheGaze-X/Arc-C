using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public class CriAtomClip : CriAtomClipBase
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x3709BB0", Offset = "0x37087B0", VA = "0x183709BB0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000AE")]
		public override string CueName
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x3709C80", Offset = "0x3708880", VA = "0x183709C80", Slot = "11")]
		public override CriAtomExAcb GetAcb()
		{
			return null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x3709C90", Offset = "0x3708890", VA = "0x183709C90")]
		private CriAtomCueSheet GetCueSheet()
		{
			return null;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000AF")]
		public override string AcbPath
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x3709F60", Offset = "0x3708B60", VA = "0x183709F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000B0")]
		public override string AwbPath
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x370A000", Offset = "0x3708C00", VA = "0x18370A000", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x3709CA0", Offset = "0x37088A0", VA = "0x183709CA0", Slot = "14")]
		public override void SetCueFromAtomSource(CriAtomSourceBase atomSource)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x3709EE0", Offset = "0x3708AE0", VA = "0x183709EE0")]
		public CriAtomClip()
		{
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x28")]
		public string cueSheet;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x30")]
		public string cueName;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x38")]
		public CriAtomBehaviour templateBehaviour;
	}
}
