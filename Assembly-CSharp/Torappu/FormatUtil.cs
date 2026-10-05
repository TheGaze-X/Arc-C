using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public class FormatUtil : SharedFormatUtil
	{
		// Token: 0x06005C42 RID: 23618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x1CF0F30", Offset = "0x1CEFB30", VA = "0x181CF0F30")]
		public static void FormatNumberWithUnit(long number, out string strFormat)
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x1CF0EA0", Offset = "0x1CEFAA0", VA = "0x181CF0EA0")]
		public static string FormatNumWithThousand(long value)
		{
			return null;
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x1CF0470", Offset = "0x1CEF070", VA = "0x181CF0470")]
		public static string FormatCostValue(int value)
		{
			return null;
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x1CF0BD0", Offset = "0x1CEF7D0", VA = "0x181CF0BD0")]
		public static string FormatNameCardNumber(int number)
		{
			return null;
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x1CF1190", Offset = "0x1CEFD90", VA = "0x181CF1190")]
		public static void FormatNumber(long number, ItemType type, out string strNum)
		{
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x0002F238 File Offset: 0x0002D438
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x1CEEDE0", Offset = "0x1CED9E0", VA = "0x181CEEDE0")]
		public static int CountOfDigits(int number)
		{
			return 0;
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x1CF07A0", Offset = "0x1CEF3A0", VA = "0x181CF07A0")]
		public static string FormatGetRomanNumerals(int n)
		{
			return null;
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x1CF0B10", Offset = "0x1CEF710", VA = "0x181CF0B10")]
		public static string FormatMultiLineTextFromData(string text)
		{
			return null;
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x1CF1DF0", Offset = "0x1CF09F0", VA = "0x181CF1DF0")]
		public static string FormatToNonBreakingSpace(string text)
		{
			return null;
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x1CF1520", Offset = "0x1CF0120", VA = "0x181CF1520")]
		public static string FormatRichTextFromData(string richText)
		{
			return null;
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x1CF3590", Offset = "0x1CF2190", VA = "0x181CF3590")]
		public static string RemoveRichTextFromString(string richText)
		{
			return null;
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x1CEF220", Offset = "0x1CEDE20", VA = "0x181CEF220")]
		public static void FormatClickableRichTextFromData(string richText, ref UICommentedTextDataBundle result)
		{
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x0002F250 File Offset: 0x0002D450
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x1CF49B0", Offset = "0x1CF35B0", VA = "0x181CF49B0")]
		private static FormatUtil.TagHandleRet _FormatClickableRichTextTag(SharedFormatUtil.LightStringStream stream, string tag, List<UICommentedTextData> tagList, int outerStartIndex)
		{
			return default(FormatUtil.TagHandleRet);
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x0002F268 File Offset: 0x0002D468
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x1CF5BE0", Offset = "0x1CF47E0", VA = "0x181CF5BE0")]
		private static int _PushNonTagRange(SharedFormatUtil.LightStringStream stream, RangeInt tagRange, StringBuilder builder)
		{
			return 0;
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x0002F280 File Offset: 0x0002D480
		[Token(Token = "0x6005C50")]
		[Address(RVA = "0x1CF4010", Offset = "0x1CF2C10", VA = "0x181CF4010")]
		private static int _CountRichTextPrefixLength(string target)
		{
			return 0;
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x0002F298 File Offset: 0x0002D498
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x1CF3EF0", Offset = "0x1CF2AF0", VA = "0x181CF3EF0")]
		private static bool _CheckIfUGUIRichTextTag(string tagStr)
		{
			return default(bool);
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x1CF5700", Offset = "0x1CF4300", VA = "0x181CF5700")]
		private static FormatUtil.ClickableRichTextType _HandleClickableRichTextTags(string startTag, string endTag, StringBuilder content, out string result, out UICommentedTextData tagData)
		{
			return FormatUtil.ClickableRichTextType.NONE;
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		[Token(Token = "0x6005C53")]
		[Address(RVA = "0x1CF4340", Offset = "0x1CF2F40", VA = "0x181CF4340")]
		private static int _CountValidVertexLength(StringBuilder content)
		{
			return 0;
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
		[Token(Token = "0x6005C54")]
		[Address(RVA = "0x1CF41C0", Offset = "0x1CF2DC0", VA = "0x181CF41C0")]
		private static int _CountValidVertexLength(string content)
		{
			return 0;
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		[Token(Token = "0x6005C55")]
		[Address(RVA = "0x1CF5B50", Offset = "0x1CF4750", VA = "0x181CF5B50")]
		private static bool _IsValidVertexChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C56")]
		[Address(RVA = "0x1CEEE70", Offset = "0x1CEDA70", VA = "0x181CEEE70")]
		public static void FormatAvgSplitContentTextFromData(string richText, ref ListDict<int, string> result)
		{
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C57")]
		[Address(RVA = "0x1CF2A80", Offset = "0x1CF1680", VA = "0x181CF2A80")]
		public static string JoinAvgSplitContentText(ListDict<int, string> contentDict)
		{
			return null;
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x0002F310 File Offset: 0x0002D510
		[Token(Token = "0x6005C58")]
		[Address(RVA = "0x1CF44C0", Offset = "0x1CF30C0", VA = "0x181CF44C0")]
		private static FormatUtil.TagHandleRet _FormatAvgSplitContentTextTag(SharedFormatUtil.LightStringStream stream, string tag, ListDict<int, string> contentDict, int outerStartIndex)
		{
			return default(FormatUtil.TagHandleRet);
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x0002F328 File Offset: 0x0002D528
		[Token(Token = "0x6005C59")]
		[Address(RVA = "0x1CF52B0", Offset = "0x1CF3EB0", VA = "0x181CF52B0")]
		private static FormatUtil.ClickableRichTextType _HandleAvgSplitContentTextTags(string startTag, string endTag, StringBuilder content, ListDict<int, string> contentDict, int contentIndex, out string result)
		{
			return FormatUtil.ClickableRichTextType.NONE;
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5A")]
		[Address(RVA = "0x1CF12F0", Offset = "0x1CEFEF0", VA = "0x181CF12F0")]
		public static string FormatParamedText(string text, Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5B")]
		[Address(RVA = "0x1CF1BE0", Offset = "0x1CF07E0", VA = "0x181CF1BE0")]
		public static string FormatTimeDelta(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x1CF3810", Offset = "0x1CF2410", VA = "0x181CF3810")]
		public static void SplitDecimalNumber(int number, List<int> digitList)
		{
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x1CF1A80", Offset = "0x1CF0680", VA = "0x181CF1A80")]
		public static string FormatTimeDeltaStrFromNow(long targetTs)
		{
			return null;
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x1CF1840", Offset = "0x1CF0440", VA = "0x181CF1840")]
		public static void FormatTimeDeltaSplit(TimeSpan timeSpan, out string num, out string unit)
		{
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x1CF06F0", Offset = "0x1CEF2F0", VA = "0x181CF06F0")]
		public static string FormatDateTimeyyyyMMdd(DateTime dateTime)
		{
			return null;
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x1CF0590", Offset = "0x1CEF190", VA = "0x181CF0590")]
		public static string FormatDateTimeyyyyMMddHHmm(DateTime dateTime)
		{
			return null;
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x1CF0640", Offset = "0x1CEF240", VA = "0x181CF0640")]
		public static string FormatDateTimeyyyyMMddHHmmss(DateTime dateTime)
		{
			return null;
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x1CF4F30", Offset = "0x1CF3B30", VA = "0x181CF4F30")]
		private static string _FormatParamedItem(string item, Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x1CEF670", Offset = "0x1CEE270", VA = "0x181CEF670")]
		public static void FormatClockTimeFromMillsec(long millsec, out int hour, out int minute, out int second)
		{
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x1CEF980", Offset = "0x1CEE580", VA = "0x181CEF980")]
		public static void FormatClockTimeFromSecond(int sec, out int hour, out int minute, out int second)
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x1CEF7C0", Offset = "0x1CEE3C0", VA = "0x181CEF7C0")]
		public static string FormatClockTimeFromSecond(long second)
		{
			return null;
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C66")]
		[Address(RVA = "0x1CF2D70", Offset = "0x1CF1970", VA = "0x181CF2D70")]
		public static string ParseTimeByDay(int timeInSec)
		{
			return null;
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x1CF3240", Offset = "0x1CF1E40", VA = "0x181CF3240")]
		public static string ParseTimeHHmmSS(int timeInSec)
		{
			return null;
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x1CF3490", Offset = "0x1CF2090", VA = "0x181CF3490")]
		public static string ParseTimemmSS(int timeInSec)
		{
			return null;
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x1CF3380", Offset = "0x1CF1F80", VA = "0x181CF3380")]
		public static string ParseTimeHHmm(int timeInSec)
		{
			return null;
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x1CF25C0", Offset = "0x1CF11C0", VA = "0x181CF25C0")]
		public static string HexToString(string hex)
		{
			return null;
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x0002F340 File Offset: 0x0002D540
		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x1CF22E0", Offset = "0x1CF0EE0", VA = "0x181CF22E0")]
		public static int HexStringToBinary(string hex, out byte[] outBytes)
		{
			return 0;
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x1CEE760", Offset = "0x1CED360", VA = "0x181CEE760")]
		public static string BinaryToBase64(byte[] binary, int index, int length)
		{
			return null;
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x0002F358 File Offset: 0x0002D558
		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x1CEE630", Offset = "0x1CED230", VA = "0x181CEE630")]
		public static int Base64ToBinary(string encodedStr, out byte[] binary)
		{
			return 0;
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x0002F370 File Offset: 0x0002D570
		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x1CEFB50", Offset = "0x1CEE750", VA = "0x181CEFB50")]
		public static Color FormatColorFromData(string colorString)
		{
			return default(Color);
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0x1CF1660", Offset = "0x1CF0260", VA = "0x181CF1660")]
		public static string FormatSmallFloat(float value)
		{
			return null;
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C70")]
		[Address(RVA = "0x1CEFD30", Offset = "0x1CEE930", VA = "0x181CEFD30")]
		public static string FormatCommonLogTraceForInvestigation(object content)
		{
			return null;
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C71")]
		[Address(RVA = "0x1CF2700", Offset = "0x1CF1300", VA = "0x181CF2700")]
		public static string HilightTimeContent(int seconds, Color color)
		{
			return null;
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x0002F388 File Offset: 0x0002D588
		[Token(Token = "0x6005C72")]
		[Address(RVA = "0x1CEE880", Offset = "0x1CED480", VA = "0x181CEE880")]
		public static bool CalcFriendLastLoginString(DateTime lastOnlineTime, out string timeStr)
		{
			return default(bool);
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C73")]
		[Address(RVA = "0x1CF1FE0", Offset = "0x1CF0BE0", VA = "0x181CF1FE0")]
		public static string GetCharacterBuildableTypePositionName(BuildableType deployPosition)
		{
			return null;
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C74")]
		[Address(RVA = "0x1CEECE0", Offset = "0x1CED8E0", VA = "0x181CEECE0")]
		public static byte[] ComputeHash(string input)
		{
			return null;
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C75")]
		[Address(RVA = "0x1CEEA00", Offset = "0x1CED600", VA = "0x181CEEA00")]
		public static byte[] ComputeHashByte(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C76")]
		[Address(RVA = "0x1CEEB40", Offset = "0x1CED740", VA = "0x181CEEB40")]
		public static byte[] ComputeHashFixedBytes(byte[] bytes, int hashByteCount)
		{
			return null;
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		[Token(Token = "0x6005C77")]
		[Address(RVA = "0x1CEE980", Offset = "0x1CED580", VA = "0x181CEE980")]
		public static uint ComputeELFHash(string chars)
		{
			return 0U;
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x1CF1EA0", Offset = "0x1CF0AA0", VA = "0x181CF1EA0")]
		public static string GenRandomCharsAndNums(int len)
		{
			return null;
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x1CF1720", Offset = "0x1CF0320", VA = "0x181CF1720")]
		public static string FormatStageCostApValue(int value)
		{
			return null;
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7A")]
		[Address(RVA = "0x1CF3A10", Offset = "0x1CF2610", VA = "0x181CF3A10")]
		public static string UrlEncode(string content)
		{
			return null;
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7B")]
		[Address(RVA = "0x1CF3980", Offset = "0x1CF2580", VA = "0x181CF3980")]
		public static string UrlDecode(string content)
		{
			return null;
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x1CF0900", Offset = "0x1CEF500", VA = "0x181CF0900")]
		public static string FormatHandbookName(List<string> strList, bool useHandbookColor)
		{
			return null;
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x1CF0DE0", Offset = "0x1CEF9E0", VA = "0x181CF0DE0")]
		public static string FormatNickNameWithDoctorPrefix(string nickname)
		{
			return null;
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x1CF0CE0", Offset = "0x1CEF8E0", VA = "0x181CF0CE0")]
		public static string FormatNickNameAndNumWithDoctorPrefix(string nickname, string nickNumber)
		{
			return null;
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0x1CF3AA0", Offset = "0x1CF26A0", VA = "0x181CF3AA0")]
		public static bool ValidateIdCardNum(string cardNum)
		{
			return default(bool);
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF15E0", VA = "0x181CF29E0")]
		public static char IDCardInputTextValidater(char charToValidate)
		{
			return '\0';
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x1CF5D10", Offset = "0x1CF4910", VA = "0x181CF5D10")]
		private static bool _ValidateCardGen1(List<int> cardNum)
		{
			return default(bool);
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x0002F400 File Offset: 0x0002D600
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x1CF5E00", Offset = "0x1CF4A00", VA = "0x181CF5E00")]
		private static bool _ValidateCardGen2(List<int> cardNum)
		{
			return default(bool);
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x1CF20F0", Offset = "0x1CF0CF0", VA = "0x181CF20F0")]
		public static string GetPingFormatStr(List<PingCond> conds, int ping, string format)
		{
			return null;
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x1CF66C0", Offset = "0x1CF52C0", VA = "0x181CF66C0")]
		public FormatUtil()
		{
		}

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] ARABIC_NUM;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] ROMAN_NUM;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		private const string CLICKABLE_RICH_TEXT_TAG = "$";

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		private const string CLICKABLE_RICH_TEXT_RANGE_TAG = "range=";

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<int> s_sharedIdCardNum;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] ID_CARD_WEIGHT;

		// Token: 0x04002200 RID: 8704
		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] ID_CARD_VALIDATE;

		// Token: 0x04002201 RID: 8705
		[Token(Token = "0x4002201")]
		public const string PING_NEGATIVE_STR = "-";

		// Token: 0x04002202 RID: 8706
		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FormatNumberWithUnit;

		// Token: 0x04002203 RID: 8707
		[Token(Token = "0x4002203")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FormatNumWithThousand;

		// Token: 0x04002204 RID: 8708
		[Token(Token = "0x4002204")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FormatCostValue;

		// Token: 0x04002205 RID: 8709
		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FormatNameCardNumber;

		// Token: 0x04002206 RID: 8710
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FormatNumber;

		// Token: 0x04002207 RID: 8711
		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CountOfDigits;

		// Token: 0x04002208 RID: 8712
		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FormatGetRomanNumerals;

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FormatMultiLineTextFromData;

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FormatToNonBreakingSpace;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_FormatRichTextFromData;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RemoveRichTextFromString;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_FormatClickableRichTextFromData;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FormatClickableRichTextTag;

		// Token: 0x0400220F RID: 8719
		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PushNonTagRange;

		// Token: 0x04002210 RID: 8720
		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CountRichTextPrefixLength;

		// Token: 0x04002211 RID: 8721
		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIfUGUIRichTextTag;

		// Token: 0x04002212 RID: 8722
		[Token(Token = "0x4002212")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleClickableRichTextTags;

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CountValidVertexLength;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix1__CountValidVertexLength;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__IsValidVertexChar;

		// Token: 0x04002216 RID: 8726
		[Token(Token = "0x4002216")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_FormatAvgSplitContentTextFromData;

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_JoinAvgSplitContentText;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__FormatAvgSplitContentTextTag;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__HandleAvgSplitContentTextTags;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_FormatParamedText;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_FormatTimeDelta;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SplitDecimalNumber;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_FormatTimeDeltaStrFromNow;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_FormatTimeDeltaSplit;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_FormatDateTimeyyyyMMdd;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_FormatDateTimeyyyyMMddHHmm;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_FormatDateTimeyyyyMMddHHmmss;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__FormatParamedItem;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_FormatClockTimeFromMillsec;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_FormatClockTimeFromSecond;

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix1_FormatClockTimeFromSecond;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_ParseTimeByDay;

		// Token: 0x04002227 RID: 8743
		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ParseTimeHHmmSS;

		// Token: 0x04002228 RID: 8744
		[Token(Token = "0x4002228")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ParseTimemmSS;

		// Token: 0x04002229 RID: 8745
		[Token(Token = "0x4002229")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ParseTimeHHmm;

		// Token: 0x0400222A RID: 8746
		[Token(Token = "0x400222A")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_HexToString;

		// Token: 0x0400222B RID: 8747
		[Token(Token = "0x400222B")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_HexStringToBinary;

		// Token: 0x0400222C RID: 8748
		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_BinaryToBase64;

		// Token: 0x0400222D RID: 8749
		[Token(Token = "0x400222D")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_Base64ToBinary;

		// Token: 0x0400222E RID: 8750
		[Token(Token = "0x400222E")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_FormatColorFromData;

		// Token: 0x0400222F RID: 8751
		[Token(Token = "0x400222F")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_FormatSmallFloat;

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_FormatCommonLogTraceForInvestigation;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_HilightTimeContent;

		// Token: 0x04002232 RID: 8754
		[Token(Token = "0x4002232")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_CalcFriendLastLoginString;

		// Token: 0x04002233 RID: 8755
		[Token(Token = "0x4002233")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_GetCharacterBuildableTypePositionName;

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_ComputeHash;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_ComputeHashByte;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_ComputeHashFixedBytes;

		// Token: 0x04002237 RID: 8759
		[Token(Token = "0x4002237")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_ComputeELFHash;

		// Token: 0x04002238 RID: 8760
		[Token(Token = "0x4002238")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GenRandomCharsAndNums;

		// Token: 0x04002239 RID: 8761
		[Token(Token = "0x4002239")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_FormatStageCostApValue;

		// Token: 0x0400223A RID: 8762
		[Token(Token = "0x400223A")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_UrlEncode;

		// Token: 0x0400223B RID: 8763
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_UrlDecode;

		// Token: 0x0400223C RID: 8764
		[Token(Token = "0x400223C")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_FormatHandbookName;

		// Token: 0x0400223D RID: 8765
		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_FormatNickNameWithDoctorPrefix;

		// Token: 0x0400223E RID: 8766
		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_FormatNickNameAndNumWithDoctorPrefix;

		// Token: 0x0400223F RID: 8767
		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_ValidateIdCardNum;

		// Token: 0x04002240 RID: 8768
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_IDCardInputTextValidater;

		// Token: 0x04002241 RID: 8769
		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__ValidateCardGen1;

		// Token: 0x04002242 RID: 8770
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__ValidateCardGen2;

		// Token: 0x04002243 RID: 8771
		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetPingFormatStr;

		// Token: 0x04002244 RID: 8772
		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200059A RID: 1434
		[Token(Token = "0x200059A")]
		public struct BicolorFixedDigits : IHotfixable
		{
			// Token: 0x06005C86 RID: 23686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C86")]
			[Address(RVA = "0x1CE4930", Offset = "0x1CE3530", VA = "0x181CE4930")]
			public string ToUGUIString()
			{
				return null;
			}

			// Token: 0x04002245 RID: 8773
			[Token(Token = "0x4002245")]
			[FieldOffset(Offset = "0x0")]
			public uint length;

			// Token: 0x04002246 RID: 8774
			[Token(Token = "0x4002246")]
			[FieldOffset(Offset = "0x4")]
			public uint number;

			// Token: 0x04002247 RID: 8775
			[Token(Token = "0x4002247")]
			[FieldOffset(Offset = "0x8")]
			public string hexForeColor;

			// Token: 0x04002248 RID: 8776
			[Token(Token = "0x4002248")]
			[FieldOffset(Offset = "0x10")]
			public string hexBackColor;

			// Token: 0x04002249 RID: 8777
			[Token(Token = "0x4002249")]
			[FieldOffset(Offset = "0x18")]
			public bool zeroUseForeColor;

			// Token: 0x0400224A RID: 8778
			[Token(Token = "0x400224A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ToUGUIString;
		}

		// Token: 0x0200059B RID: 1435
		[Token(Token = "0x200059B")]
		private struct TagHandleRet
		{
			// Token: 0x0400224B RID: 8779
			[Token(Token = "0x400224B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly FormatUtil.TagHandleRet EMPTY;

			// Token: 0x0400224C RID: 8780
			[Token(Token = "0x400224C")]
			[FieldOffset(Offset = "0x0")]
			public string str;

			// Token: 0x0400224D RID: 8781
			[Token(Token = "0x400224D")]
			[FieldOffset(Offset = "0x8")]
			public int vertexLength;
		}

		// Token: 0x0200059C RID: 1436
		[Token(Token = "0x200059C")]
		private enum ClickableRichTextType
		{
			// Token: 0x0400224F RID: 8783
			[Token(Token = "0x400224F")]
			NONE,
			// Token: 0x04002250 RID: 8784
			[Token(Token = "0x4002250")]
			STYLE,
			// Token: 0x04002251 RID: 8785
			[Token(Token = "0x4002251")]
			CLICKABLE
		}
	}
}
