using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BD0 RID: 31696
	[Token(Token = "0x2007BD0")]
	public interface ISerializedObject
	{
		// Token: 0x0602C5CB RID: 181707
		[Token(Token = "0x602C5CB")]
		void RestoreState();

		// Token: 0x0602C5CC RID: 181708
		[Token(Token = "0x602C5CC")]
		void SaveState();

		// Token: 0x170067DB RID: 26587
		// (get) Token: 0x0602C5CD RID: 181709
		// (set) Token: 0x0602C5CE RID: 181710
		[Token(Token = "0x170067DB")]
		bool IsRestored { [Token(Token = "0x602C5CD")] get; [Token(Token = "0x602C5CE")] set; }

		// Token: 0x170067DC RID: 26588
		// (get) Token: 0x0602C5CF RID: 181711
		// (set) Token: 0x0602C5D0 RID: 181712
		[Token(Token = "0x170067DC")]
		List<UnityEngine.Object> SerializedObjectReferences { [Token(Token = "0x602C5CF")] get; [Token(Token = "0x602C5D0")] set; }

		// Token: 0x170067DD RID: 26589
		// (get) Token: 0x0602C5D1 RID: 181713
		// (set) Token: 0x0602C5D2 RID: 181714
		[Token(Token = "0x170067DD")]
		List<string> SerializedStateKeys { [Token(Token = "0x602C5D1")] get; [Token(Token = "0x602C5D2")] set; }

		// Token: 0x170067DE RID: 26590
		// (get) Token: 0x0602C5D3 RID: 181715
		// (set) Token: 0x0602C5D4 RID: 181716
		[Token(Token = "0x170067DE")]
		List<string> SerializedStateValues { [Token(Token = "0x602C5D3")] get; [Token(Token = "0x602C5D4")] set; }
	}
}
