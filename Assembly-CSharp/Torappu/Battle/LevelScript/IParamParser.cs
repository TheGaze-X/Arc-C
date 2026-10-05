using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002870 RID: 10352
	[Token(Token = "0x2002870")]
	public interface IParamParser
	{
		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x0601137F RID: 70527
		[Token(Token = "0x170025E6")]
		ParamRealType[] paramRealTypeMask { [Token(Token = "0x601137F")] get; }

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06011380 RID: 70528
		[Token(Token = "0x170025E7")]
		ParamRealType[] paramListRealTypeMask { [Token(Token = "0x6011380")] get; }

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06011381 RID: 70529
		[Token(Token = "0x170025E8")]
		Type systemType { [Token(Token = "0x6011381")] get; }

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06011382 RID: 70530
		[Token(Token = "0x170025E9")]
		Type systemListType { [Token(Token = "0x6011382")] get; }

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06011383 RID: 70531
		[Token(Token = "0x170025EA")]
		int lengthPerItem { [Token(Token = "0x6011383")] get; }

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06011384 RID: 70532
		[Token(Token = "0x170025EB")]
		ParamRealType paramRealType { [Token(Token = "0x6011384")] get; }

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06011385 RID: 70533
		[Token(Token = "0x170025EC")]
		ParamRealType paramListRealType { [Token(Token = "0x6011385")] get; }

		// Token: 0x06011386 RID: 70534
		[Token(Token = "0x6011386")]
		void SetRaw(ParamValue paramValue, object value);

		// Token: 0x06011387 RID: 70535
		[Token(Token = "0x6011387")]
		int GetListItemLength(ParamValue paramValue);

		// Token: 0x06011388 RID: 70536
		[Token(Token = "0x6011388")]
		ParamVariable ToVariable(ParamValue paramValue);

		// Token: 0x06011389 RID: 70537
		[Token(Token = "0x6011389")]
		Type GetSystemType(ParamRealType valueType);

		// Token: 0x0601138A RID: 70538
		[Token(Token = "0x601138A")]
		object GetOrNewValueObject(ParamValue paramValue);

		// Token: 0x0601138B RID: 70539
		[Token(Token = "0x601138B")]
		void ToStringSingle(ParamValue paramValue, out string result, bool force = false);

		// Token: 0x0601138C RID: 70540
		[Token(Token = "0x601138C")]
		void ToStringList(ParamValue paramValue, List<string> resultList);
	}
}
