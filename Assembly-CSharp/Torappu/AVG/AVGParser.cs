using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001EE6 RID: 7910
	[Token(Token = "0x2001EE6")]
	public class AVGParser : IAVGParser
	{
		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x0600C445 RID: 50245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C446 RID: 50246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700176F")]
		public IAVGVariableConverter variableConverter
		{
			[Token(Token = "0x600C445")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600C446")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x00048018 File Offset: 0x00046218
		[Token(Token = "0x600C447")]
		[Address(RVA = "0x3422F90", Offset = "0x3421B90", VA = "0x183422F90", Slot = "5")]
		public bool TryParse(string content, out List<Command> commands)
		{
			return default(bool);
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C448")]
		[Address(RVA = "0x3423520", Offset = "0x3422120", VA = "0x183423520")]
		private void _AppendEndTip(ref List<Command> commands)
		{
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C449")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("UNITY_EDITOR")]
		private void _StoreOriginLinesToCmd(Command cmd, AVGParser.TextBlock block)
		{
		}

		// Token: 0x0600C44A RID: 50250 RVA: 0x00048030 File Offset: 0x00046230
		[Token(Token = "0x600C44A")]
		[Address(RVA = "0x3422F50", Offset = "0x3421B50", VA = "0x183422F50")]
		public bool TryParse(string content, out Story story)
		{
			return default(bool);
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x00048048 File Offset: 0x00046248
		[Token(Token = "0x600C44B")]
		[Address(RVA = "0x3422910", Offset = "0x3421510", VA = "0x183422910", Slot = "6")]
		public bool TryParse(string content, Story.StoryParam param, out Story story)
		{
			return default(bool);
		}

		// Token: 0x0600C44C RID: 50252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C44C")]
		[Address(RVA = "0x3422820", Offset = "0x3421420", VA = "0x183422820", Slot = "4")]
		public string GetErrorMessage()
		{
			return null;
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x00048060 File Offset: 0x00046260
		[Token(Token = "0x600C44D")]
		[Address(RVA = "0x3422740", Offset = "0x3421340", VA = "0x183422740")]
		public static bool CheckIfSkipLine(string str)
		{
			return default(bool);
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x00048078 File Offset: 0x00046278
		[Token(Token = "0x600C44E")]
		[Address(RVA = "0x34226B0", Offset = "0x34212B0", VA = "0x1834226B0")]
		public static bool CheckIfComment(string str)
		{
			return default(bool);
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44F")]
		[Address(RVA = "0x3423600", Offset = "0x3422200", VA = "0x183423600")]
		private void _AppendError(string error)
		{
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C450")]
		[Address(RVA = "0x3423680", Offset = "0x3422280", VA = "0x183423680")]
		private Command _ParseCommand(AVGParser.TextBlock block)
		{
			return null;
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x00048090 File Offset: 0x00046290
		[Token(Token = "0x600C451")]
		[Address(RVA = "0x3423DE0", Offset = "0x34229E0", VA = "0x183423DE0")]
		private AVGParser.TextBlock _ReadNextBlock(StringReader reader)
		{
			return default(AVGParser.TextBlock);
		}

		// Token: 0x0600C452 RID: 50258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C452")]
		[Address(RVA = "0x3423F80", Offset = "0x3422B80", VA = "0x183423F80")]
		private string _ReplaceEqualSignWithColon(string str)
		{
			return null;
		}

		// Token: 0x0600C453 RID: 50259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C453")]
		[Address(RVA = "0x3424210", Offset = "0x3422E10", VA = "0x183424210")]
		public AVGParser()
		{
		}

		// Token: 0x0400C8D2 RID: 51410
		[Token(Token = "0x400C8D2")]
		private const char ESCAPE_CHAR = '\\';

		// Token: 0x0400C8D3 RID: 51411
		[Token(Token = "0x400C8D3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex COMMAND_REGEX;

		// Token: 0x0400C8D4 RID: 51412
		[Token(Token = "0x400C8D4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Regex COMMENT_REGEX;

		// Token: 0x0400C8D5 RID: 51413
		[Token(Token = "0x400C8D5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Regex ONLY_SPACE_REGEX;

		// Token: 0x0400C8D6 RID: 51414
		[Token(Token = "0x400C8D6")]
		[FieldOffset(Offset = "0x10")]
		private List<string> m_errors;

		// Token: 0x02001EE7 RID: 7911
		[Token(Token = "0x2001EE7")]
		private struct TextBlock
		{
			// Token: 0x0600C455 RID: 50261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C455")]
			[Address(RVA = "0x3436560", Offset = "0x3435160", VA = "0x183436560")]
			[Conditional("UNITY_EDITOR")]
			public void EditorOnlyAddOriginTextLine(string str)
			{
			}

			// Token: 0x0600C456 RID: 50262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C456")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			public List<string> EditorOnlyGetOriginTextline()
			{
				return null;
			}

			// Token: 0x0600C457 RID: 50263 RVA: 0x000480A8 File Offset: 0x000462A8
			[Token(Token = "0x600C457")]
			[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0400C8D8 RID: 51416
			[Token(Token = "0x400C8D8")]
			[FieldOffset(Offset = "0x0")]
			public string text;

			// Token: 0x0400C8D9 RID: 51417
			[Token(Token = "0x400C8D9")]
			[FieldOffset(Offset = "0x8")]
			public bool isConcat;

			// Token: 0x0400C8DA RID: 51418
			[Token(Token = "0x400C8DA")]
			[FieldOffset(Offset = "0xC")]
			public int readLineCount;

			// Token: 0x0400C8DB RID: 51419
			[Token(Token = "0x400C8DB")]
			[FieldOffset(Offset = "0x10")]
			private List<string> editorOnlyOriginTextLine;
		}
	}
}
