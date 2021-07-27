using System.Collections.Generic;

namespace Interfaces
{
    public interface ITaskService<T>
    {
        bool CanRemove { get; }
        void Clear();

        List<T> Items { get; }

        void AddItem(T toDoItem);
        void RemoveDone();

        bool CanUndo { get; }
        void Undo();

        bool CanRedo { get; }
        void Redo();

        bool CanSave { get; }
    }
}
