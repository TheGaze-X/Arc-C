using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	internal interface ICurvesOwner
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A6 RID: 166
		[Token(Token = "0x1700002F")]
		AnimationClip curves { [Token(Token = "0x60000A6")] get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A7 RID: 167
		[Token(Token = "0x17000030")]
		bool hasCurves { [Token(Token = "0x60000A7")] get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A8 RID: 168
		[Token(Token = "0x17000031")]
		double duration { [Token(Token = "0x60000A8")] get; }

		// Token: 0x060000A9 RID: 169
		[Token(Token = "0x60000A9")]
		void CreateCurves(string curvesClipName);

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AA RID: 170
		[Token(Token = "0x17000032")]
		string defaultCurvesName { [Token(Token = "0x60000AA")] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AB RID: 171
		[Token(Token = "0x17000033")]
		Object asset { [Token(Token = "0x60000AB")] get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AC RID: 172
		[Token(Token = "0x17000034")]
		Object assetOwner { [Token(Token = "0x60000AC")] get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AD RID: 173
		[Token(Token = "0x17000035")]
		TrackAsset targetTrack { [Token(Token = "0x60000AD")] get; }
	}
}
