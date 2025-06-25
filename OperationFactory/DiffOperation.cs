using System.Diagnostics.CodeAnalysis;

namespace UndoDemo;

public class DiffOperation<T>
{
    // 记录对象
    [NotNull]
    public T? Object { get; init; }

    // 操作表格列的名称
    public string? ColumnName { get; init; }

    // 操作类型
    public OperationType OperationType { get; init; }

    /// <summary>
    /// 操作发生时的原始索引
    /// </summary>
    public int OldIndex { get; init; }

    /// <summary>
    /// 操作后的新索引
    /// </summary>
    public int NewIndex { get; init; }

    /// <summary>
    /// 旧值
    /// </summary>
    public string? OldValue { get; init; }

    /// <summary>
    /// 新值
    /// </summary>
    [NotNull]
    public string? NewValue { get; init; }
}

public static class DiffOperationFactory<T> where T : ICloneable<T>
{
    // 向表格中添加数据
    public static DiffOperation<T> CreateAdd(int index, T item) => new()
    {
        OperationType = OperationType.Add,
        NewIndex = index,
        Object = item.Clone()
    };
}