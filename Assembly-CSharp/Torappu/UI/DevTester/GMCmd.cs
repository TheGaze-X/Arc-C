using System;
using Il2CppDummyDll;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050EF RID: 20719
	[Token(Token = "0x20050EF")]
	public class GMCmd
	{
		// Token: 0x0601E9F3 RID: 125427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9F3")]
		[Address(RVA = "0x18625E0", Offset = "0x18611E0", VA = "0x1818625E0")]
		public void Parse(string commandLine)
		{
		}

		// Token: 0x1700476D RID: 18285
		// (get) Token: 0x0601E9F4 RID: 125428 RVA: 0x000AF170 File Offset: 0x000AD370
		[Token(Token = "0x1700476D")]
		public int argSize
		{
			[Token(Token = "0x601E9F4")]
			[Address(RVA = "0x1862620", Offset = "0x1861220", VA = "0x181862620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E9F5 RID: 125429 RVA: 0x000AF188 File Offset: 0x000AD388
		[Token(Token = "0x601E9F5")]
		[Address(RVA = "0x1862450", Offset = "0x1861050", VA = "0x181862450")]
		public bool IsCmd(string cmd)
		{
			return default(bool);
		}

		// Token: 0x0601E9F6 RID: 125430 RVA: 0x000AF1A0 File Offset: 0x000AD3A0
		[Token(Token = "0x601E9F6")]
		[Address(RVA = "0x18623B0", Offset = "0x1860FB0", VA = "0x1818623B0")]
		public bool HasArg(string name)
		{
			return default(bool);
		}

		// Token: 0x0601E9F7 RID: 125431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E9F7")]
		[Address(RVA = "0x1862120", Offset = "0x1860D20", VA = "0x181862120")]
		public string GetArg(string name)
		{
			return null;
		}

		// Token: 0x0601E9F8 RID: 125432 RVA: 0x000AF1B8 File Offset: 0x000AD3B8
		[Token(Token = "0x601E9F8")]
		[Address(RVA = "0x18622E0", Offset = "0x1860EE0", VA = "0x1818622E0")]
		public int GetIntArg(string name)
		{
			return 0;
		}

		// Token: 0x0601E9F9 RID: 125433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E9F9")]
		[Address(RVA = "0x18620E0", Offset = "0x1860CE0", VA = "0x1818620E0")]
		public string GetArgAt(int idx)
		{
			return null;
		}

		// Token: 0x0601E9FA RID: 125434 RVA: 0x000AF1D0 File Offset: 0x000AD3D0
		[Token(Token = "0x601E9FA")]
		[Address(RVA = "0x1862280", Offset = "0x1860E80", VA = "0x181862280")]
		public int GetIntArgAt(int idx)
		{
			return 0;
		}

		// Token: 0x0601E9FB RID: 125435 RVA: 0x000AF1E8 File Offset: 0x000AD3E8
		[Token(Token = "0x601E9FB")]
		[Address(RVA = "0x18621E0", Offset = "0x1860DE0", VA = "0x1818621E0")]
		public bool GetBoolArgAt(int idx)
		{
			return default(bool);
		}

		// Token: 0x0601E9FC RID: 125436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E9FC")]
		[Address(RVA = "0x1862490", Offset = "0x1861090", VA = "0x181862490")]
		public string MergeArgsToRawString()
		{
			return null;
		}

		// Token: 0x0601E9FD RID: 125437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GMCmd()
		{
		}

		// Token: 0x040290BD RID: 168125
		[Token(Token = "0x40290BD")]
		private const char CHAR_SPLIT = ' ';

		// Token: 0x040290BE RID: 168126
		[Token(Token = "0x40290BE")]
		[FieldOffset(Offset = "0x10")]
		private string[] _cmds;
	}
}
